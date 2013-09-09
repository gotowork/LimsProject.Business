using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LimsProject.BusinessLayer.Modules
{
    public class CBatchManager
    {
        CBatch_detail_aa_twofold control_sample = new CBatch_detail_aa_twofold();
        CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
        CTemplate_method oTemplate_method = new CTemplate_method();
        CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();
        CRecep_sample_detail oRecep_sample_detail = new CRecep_sample_detail();
        CCorrelative Correlative = new CCorrelative();
        Methods methods = new Methods();
        bool Enabled_retest = false;
        CRetest oRetest = new CRetest();

        public void SaveControlSample(int idtemplate_method_aa, long idbatch)
        {
            CTemplate_method template_method = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(idtemplate_method_aa));
            CCorrelative correlative = new CCorrelativeFactory().GetByPrimaryKey(new CCorrelativeKeys(template_method.Cod_type_sample));
            CTemplate_method_aa templaate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method_aa));
            control_sample.Idtemplate_method = templaate_method_aa.Idtemplate_method;
            //control_sample.Idrecep_sample = idrecep_sample;
            //control_sample.Idrecep_sample_detail = idrecep_sample_detail;
            //control_sample.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
            control_sample.Weight1 = templaate_method_aa.Weight;
            control_sample.Weight2 = templaate_method_aa.Weight;
            control_sample.Volumen1 = templaate_method_aa.Volumen;
            control_sample.Volumen2 = templaate_method_aa.Volumen;
            control_sample.Dilu2 = templaate_method_aa.Dilution2;
            control_sample.Dilu3 = templaate_method_aa.Dilution3;

            control_sample.Flag_dilu2 = false;
            control_sample.Flag_dilu3 = false;

            control_sample.Flag_mri = 1;
            control_sample.Fum = methods.GetFactorConvertionUM(templaate_method_aa.Idtemplate_method);
            control_sample.Qaqc_blk = 3;
            control_sample.Qaqc_par = 3;
            control_sample.Qaqc_mr = 3;
            control_sample.Qaqc_error = 0;
            control_sample.Qaqc_approve = false;
            control_sample.Qaqc_review = false;            
            control_sample.Qaqc_has_retest = 0;
            control_sample.Qaqc_tmp_retest = 0;
            control_sample.Qaqc_tmp_retest_idmethod = 0;
            control_sample.Qaqc_approve_text = "";
            control_sample.Qaqc_review_text = "";

            // --- insert mri
            CBatch oBatch = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(idbatch));
            int num_free_places = GetNumFreePlacesInBatch(idbatch, templaate_method_aa.Idtemplate_method);

            if (num_free_places >= 1)
            {
                if (!Convert.ToBoolean(oBatch.Has_sample_control)) // batch no tiene mri
                {
                    long index_mri = GetIndexMriPosition(idbatch);
                    if (index_mri > 0)
                    {
                        // --- insert mri
                        control_sample.Cod_interno = index_mri;
                        control_sample.Idbatch = idbatch;
                        control_sample.Cod_sample = MComun.FormatCorrelativeCode(correlative.Prefix + correlative.Cod_serie, index_mri, Convert.ToInt32(correlative.Num_digits));
                        if (faBatch_detail_aa_twofold.Insert(control_sample))
                        {
                            oBatch.Has_sample_control = true;
                            new CBatchFactory().Update(oBatch);
                        }
                    }
                }
            }
        }

        public void CallSaveSampleBatchWithRetest(int idtemplate_method, long idrecep_sample, long idrecep_sample_detail, long idrecep_sample_detail_elem, long cod_interno, string str_cod_interno, string user, CCorrelative correlative, int Qaqc_par_prev_batch, long origin_batch)
        {
            Correlative = correlative;

            CBatch_detail_aa_twofold oBatch_detail_aa_twofold = new CBatch_detail_aa_twofold();
            oTemplate_method = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(idtemplate_method));
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));
            CRecep_sample_detail oRecep_sample_detail = new CRecep_sample_detailFactory().GetByPrimaryKey(new CRecep_sample_detailKeys(idrecep_sample_detail));
            CDescription_sample oDescription_sample = new CDescription_sampleFactory().GetByPrimaryKey(new CDescription_sampleKeys(oRecep_sample_detail.Cod_des_sample));

            if (oTemplate_method_aa != null)
            {
                oBatch_detail_aa_twofold.Idtemplate_method = idtemplate_method;
                oBatch_detail_aa_twofold.Idrecep_sample = idrecep_sample;
                oBatch_detail_aa_twofold.Idrecep_sample_detail = idrecep_sample_detail;
                oBatch_detail_aa_twofold.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                oBatch_detail_aa_twofold.Idunit_result = oTemplate_method_aa.Idunit_result;
                oBatch_detail_aa_twofold.Weight1 = oTemplate_method_aa.Weight;
                oBatch_detail_aa_twofold.Weight2 = oTemplate_method_aa.Weight;
                oBatch_detail_aa_twofold.Volumen1 = oTemplate_method_aa.Volumen;
                oBatch_detail_aa_twofold.Volumen2 = oTemplate_method_aa.Volumen;
                oBatch_detail_aa_twofold.Dilu2 = oTemplate_method_aa.Dilution2;
                oBatch_detail_aa_twofold.Dilu3 = oTemplate_method_aa.Dilution3;

                oBatch_detail_aa_twofold.Flag_dilu2 = false;
                oBatch_detail_aa_twofold.Flag_dilu3 = false;

                oBatch_detail_aa_twofold.Cod_des_sample = oRecep_sample_detail.Cod_des_sample;
                oBatch_detail_aa_twofold.Order_des_sample = oDescription_sample.Priority_order;

                oBatch_detail_aa_twofold.Flag_mri = 0;
                oBatch_detail_aa_twofold.Fum = methods.GetFactorConvertionUM(idtemplate_method);
                oBatch_detail_aa_twofold.Qaqc_blk = 3;
                oBatch_detail_aa_twofold.Qaqc_par = 3;
                oBatch_detail_aa_twofold.Qaqc_mr = 3;
                oBatch_detail_aa_twofold.Qaqc_error = 0;

                oBatch_detail_aa_twofold.Qaqc_approve = false;
                oBatch_detail_aa_twofold.Qaqc_review = false;
                oBatch_detail_aa_twofold.Qaqc_has_retest = 0;
                oBatch_detail_aa_twofold.Qaqc_tmp_retest = 0;
                oBatch_detail_aa_twofold.Qaqc_tmp_retest_idmethod = 0;
                oBatch_detail_aa_twofold.Qaqc_approve_text = "";
                oBatch_detail_aa_twofold.Qaqc_review_text = "";
                oBatch_detail_aa_twofold.Qaqc_par_prev_batch = Qaqc_par_prev_batch;

                oBatch_detail_aa_twofold.Cod_interno = cod_interno;
                oBatch_detail_aa_twofold.Cod_sample = str_cod_interno;

                control_sample.Idtemplate_method = idtemplate_method;
                //control_sample.Idrecep_sample = idrecep_sample;
                //control_sample.Idrecep_sample_detail = idrecep_sample_detail;
                //control_sample.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                control_sample.Weight1 = oTemplate_method_aa.Weight;
                control_sample.Weight2 = oTemplate_method_aa.Weight;
                control_sample.Volumen1 = oTemplate_method_aa.Volumen;
                control_sample.Volumen2 = oTemplate_method_aa.Volumen;
                control_sample.Dilu2 = oTemplate_method_aa.Dilution2;
                control_sample.Dilu3 = oTemplate_method_aa.Dilution3;

                control_sample.Flag_dilu2 = false;
                control_sample.Flag_dilu3 = false;

                control_sample.Flag_mri = 1;
                control_sample.Fum = methods.GetFactorConvertionUM(idtemplate_method);
                control_sample.Qaqc_blk = 3;
                control_sample.Qaqc_par = 3;
                control_sample.Qaqc_mr = 3;
                control_sample.Qaqc_error = 0;
                control_sample.Qaqc_approve = false;
                control_sample.Qaqc_review = false;
                control_sample.Qaqc_tmp_retest_idmethod = 0;
                control_sample.Qaqc_approve_text = "";
                control_sample.Qaqc_review_text = "";

                Enabled_retest = true;
                oRetest.Idrecep_sample_detail = idrecep_sample_detail;
                oRetest.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                oRetest.Origin_batch = origin_batch;
                oRetest.Useredit1 = user;
                oRetest.Usernew = user;
                oRetest.Type_retest = 'R';
                oRetest.Status = true;

                // --- save in batch
                SaveInBatch(oBatch_detail_aa_twofold, user);
            }
        }

        // --- insert sample came from retest full batch
        public void CallSaveFromRetestFullBatch(int idtemplate_method, long idrecep_sample, long idrecep_sample_detail, long idrecep_sample_detail_elem, long cod_interno, string str_cod_interno, string user, CCorrelative correlative, int? previus_parity)
        {
            Correlative = correlative;

            CBatch_detail_aa_twofold oBatch_detail_aa_twofold = new CBatch_detail_aa_twofold();
            CTemplate_method oTemplate_method = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(idtemplate_method));
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));
            CRecep_sample_detail oRecep_sample_detail = new CRecep_sample_detailFactory().GetByPrimaryKey(new CRecep_sample_detailKeys(idrecep_sample_detail));
            CDescription_sample oDescription_sample = new CDescription_sampleFactory().GetByPrimaryKey(new CDescription_sampleKeys(oRecep_sample_detail.Cod_des_sample));

            oBatch_detail_aa_twofold.Idtemplate_method = idtemplate_method;
            oBatch_detail_aa_twofold.Idrecep_sample = idrecep_sample;
            oBatch_detail_aa_twofold.Idrecep_sample_detail = idrecep_sample_detail;
            oBatch_detail_aa_twofold.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
            oBatch_detail_aa_twofold.Idunit_result = oTemplate_method_aa.Idunit_result;
            oBatch_detail_aa_twofold.Weight1 = oTemplate_method_aa.Weight;
            oBatch_detail_aa_twofold.Weight2 = oTemplate_method_aa.Weight;
            oBatch_detail_aa_twofold.Volumen1 = oTemplate_method_aa.Volumen;
            oBatch_detail_aa_twofold.Volumen2 = oTemplate_method_aa.Volumen;
            oBatch_detail_aa_twofold.Dilu2 = oTemplate_method_aa.Dilution2;
            oBatch_detail_aa_twofold.Dilu3 = oTemplate_method_aa.Dilution3;

            oBatch_detail_aa_twofold.Flag_dilu2 = false;
            oBatch_detail_aa_twofold.Flag_dilu3 = false;

            oBatch_detail_aa_twofold.Flag_mri = 0;
            oBatch_detail_aa_twofold.Fum = methods.GetFactorConvertionUM(idtemplate_method);
            oBatch_detail_aa_twofold.Qaqc_blk = 3;
            oBatch_detail_aa_twofold.Qaqc_par = 3;
            oBatch_detail_aa_twofold.Qaqc_mr = 3;
            oBatch_detail_aa_twofold.Qaqc_error = 0;

            oBatch_detail_aa_twofold.Qaqc_approve = false;
            oBatch_detail_aa_twofold.Qaqc_review = false;
            oBatch_detail_aa_twofold.Qaqc_has_retest = 0;
            oBatch_detail_aa_twofold.Qaqc_tmp_retest = 0;
            oBatch_detail_aa_twofold.Qaqc_tmp_retest_idmethod = 0;
            oBatch_detail_aa_twofold.Qaqc_approve_text = "";
            oBatch_detail_aa_twofold.Qaqc_review_text = "";
            oBatch_detail_aa_twofold.Qaqc_par_prev_batch = previus_parity;

            oBatch_detail_aa_twofold.Cod_interno = cod_interno;
            oBatch_detail_aa_twofold.Cod_sample = str_cod_interno;
            
            oBatch_detail_aa_twofold.Cod_des_sample = oRecep_sample_detail.Cod_des_sample;
            oBatch_detail_aa_twofold.Order_des_sample = oDescription_sample.Priority_order;

            // --- control sample

            control_sample.Idtemplate_method = idtemplate_method;
            //control_sample.Idrecep_sample = idrecep_sample;
            //control_sample.Idrecep_sample_detail = idrecep_sample_detail;
            //control_sample.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
            control_sample.Weight1 = oTemplate_method_aa.Weight;
            control_sample.Weight2 = oTemplate_method_aa.Weight;
            control_sample.Volumen1 = oTemplate_method_aa.Volumen;
            control_sample.Volumen2 = oTemplate_method_aa.Volumen;
            control_sample.Dilu2 = oTemplate_method_aa.Dilution2;
            control_sample.Dilu3 = oTemplate_method_aa.Dilution3;

            control_sample.Flag_dilu2 = false;
            control_sample.Flag_dilu3 = false;

            control_sample.Flag_mri = 1;
            control_sample.Fum = methods.GetFactorConvertionUM(idtemplate_method);
            control_sample.Qaqc_blk = 3;
            control_sample.Qaqc_par = 3;
            control_sample.Qaqc_mr = 3;
            control_sample.Qaqc_error = 0;
            control_sample.Qaqc_approve = false;
            control_sample.Qaqc_review = false;
            control_sample.Qaqc_tmp_retest_idmethod = 0;
            control_sample.Qaqc_approve_text = "";
            control_sample.Qaqc_review_text = "";

            SaveInBatch(oBatch_detail_aa_twofold, user);
        } 

        // --- insert sample in batch
        public void CallSaveSampleBatch(int idtemplate_method, long idrecep_sample, long idrecep_sample_detail, long idrecep_sample_detail_elem, long cod_interno, string str_cod_interno, string user, CCorrelative correlative)
        {
            Correlative = correlative;

            CBatch_detail_aa_twofold oBatch_detail_aa_twofold = new CBatch_detail_aa_twofold();
            CTemplate_method oTemplate_method = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(idtemplate_method));
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));
            CRecep_sample_detail oRecep_sample_detail = new CRecep_sample_detailFactory().GetByPrimaryKey(new CRecep_sample_detailKeys(idrecep_sample_detail));
            CDescription_sample oDescription_sample = new CDescription_sampleFactory().GetByPrimaryKey(new CDescription_sampleKeys(oRecep_sample_detail.Cod_des_sample));

            if (oTemplate_method_aa != null)
            {
                oBatch_detail_aa_twofold.Idtemplate_method = idtemplate_method;
                oBatch_detail_aa_twofold.Idrecep_sample = idrecep_sample;
                oBatch_detail_aa_twofold.Idrecep_sample_detail = idrecep_sample_detail;
                oBatch_detail_aa_twofold.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                oBatch_detail_aa_twofold.Idunit_result = oTemplate_method_aa.Idunit_result;
                oBatch_detail_aa_twofold.Weight1 = oTemplate_method_aa.Weight;
                oBatch_detail_aa_twofold.Weight2 = oTemplate_method_aa.Weight;
                oBatch_detail_aa_twofold.Volumen1 = oTemplate_method_aa.Volumen;
                oBatch_detail_aa_twofold.Volumen2 = oTemplate_method_aa.Volumen;
                oBatch_detail_aa_twofold.Dilu2 = oTemplate_method_aa.Dilution2;
                oBatch_detail_aa_twofold.Dilu3 = oTemplate_method_aa.Dilution3;

                oBatch_detail_aa_twofold.Flag_dilu2 = false;
                oBatch_detail_aa_twofold.Flag_dilu3 = false;

                oBatch_detail_aa_twofold.Cod_des_sample = oRecep_sample_detail.Cod_des_sample;
                oBatch_detail_aa_twofold.Order_des_sample = oDescription_sample.Priority_order;

                oBatch_detail_aa_twofold.Flag_mri = 0;
                oBatch_detail_aa_twofold.Fum = methods.GetFactorConvertionUM(idtemplate_method);
                oBatch_detail_aa_twofold.Qaqc_blk = 3;
                oBatch_detail_aa_twofold.Qaqc_par = 3;
                oBatch_detail_aa_twofold.Qaqc_mr = 3;
                oBatch_detail_aa_twofold.Qaqc_error = 0;

                oBatch_detail_aa_twofold.Qaqc_approve = false;
                oBatch_detail_aa_twofold.Qaqc_review = false;
                oBatch_detail_aa_twofold.Qaqc_has_retest = 0;
                oBatch_detail_aa_twofold.Qaqc_tmp_retest = 0;
                oBatch_detail_aa_twofold.Qaqc_tmp_retest_idmethod = 0;
                oBatch_detail_aa_twofold.Qaqc_approve_text = "";
                oBatch_detail_aa_twofold.Qaqc_review_text = "";

                oBatch_detail_aa_twofold.Cod_interno = cod_interno;
                oBatch_detail_aa_twofold.Cod_sample = str_cod_interno;

                // --- control sample

                control_sample.Idtemplate_method = idtemplate_method;
                //control_sample.Idrecep_sample = idrecep_sample;
                //control_sample.Idrecep_sample_detail = idrecep_sample_detail;
                //control_sample.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                control_sample.Weight1 = oTemplate_method_aa.Weight;
                control_sample.Weight2 = oTemplate_method_aa.Weight;
                control_sample.Volumen1 = oTemplate_method_aa.Volumen;
                control_sample.Volumen2 = oTemplate_method_aa.Volumen;
                control_sample.Dilu2 = oTemplate_method_aa.Dilution2;
                control_sample.Dilu3 = oTemplate_method_aa.Dilution3;

                control_sample.Flag_dilu2 = false;
                control_sample.Flag_dilu3 = false;

                control_sample.Flag_mri = 1;
                control_sample.Fum = methods.GetFactorConvertionUM(idtemplate_method);
                control_sample.Qaqc_blk = 3;
                control_sample.Qaqc_par = 3;
                control_sample.Qaqc_mr = 3;
                control_sample.Qaqc_error = 0;
                control_sample.Qaqc_approve = false;
                control_sample.Qaqc_review = false;
                control_sample.Qaqc_tmp_retest_idmethod = 0;
                control_sample.Qaqc_approve_text = "";
                control_sample.Qaqc_review_text = "";

                SaveInBatch(oBatch_detail_aa_twofold, user);
            }
        }        
        
        private void SaveInBatch(CBatch_detail_aa_twofold oBatch_detail_aa_twofold, string user)
        {
            // --- get batch
            int idtemplate_method = Convert.ToInt32(oBatch_detail_aa_twofold.Idtemplate_method);

            long origin_batch = -1;
            if (Enabled_retest)
                origin_batch = Convert.ToInt64(oRetest.Origin_batch);

            long idbatch = Convert.ToInt64(GetBatchAvailable(idtemplate_method, user, origin_batch));

            CBatch oBatch = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(idbatch));

            int num_free_places = GetNumFreePlacesInBatch(idbatch, idtemplate_method);

            if (num_free_places >= 1)
            {
                if (!Convert.ToBoolean(oBatch.Has_sample_control)) // batch no tiene mri
                {
                    
                    long index_mri = GetIndexMriPredecessor(idbatch, Convert.ToInt64(oBatch_detail_aa_twofold.Cod_interno));

                    if (index_mri > 0)// --- el batch no tiene mri y en sus predecesores debe existir uno
                    {
                        if (num_free_places >= 2)
                        {
                            // --- insert mri
                            control_sample.Cod_interno = index_mri;
                            control_sample.Idbatch = idbatch;
                            control_sample.Cod_sample = MComun.FormatCorrelativeCode(Correlative.Prefix + Correlative.Cod_serie, index_mri, Convert.ToInt32(Correlative.Num_digits));
                            if (faBatch_detail_aa_twofold.Insert(control_sample))
                            {
                                oBatch.Has_sample_control = true;
                                new CBatchFactory().Update(oBatch);
                            }

                            // --- insert sample
                            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_towfold = new CBatch_detail_aa_twofoldFactory();
                            oBatch_detail_aa_twofold.Idbatch = idbatch;
                            faBatch_detail_aa_towfold.Insert(oBatch_detail_aa_twofold);
                            SaveRetest(idbatch);
                        }
                        if (num_free_places == 1)
                        {
                            // --- insert mri
                            control_sample.Cod_interno = index_mri;
                            control_sample.Idbatch = idbatch;
                            control_sample.Cod_sample = MComun.FormatCorrelativeCode(Correlative.Prefix + Correlative.Cod_serie, index_mri, Convert.ToInt32(Correlative.Num_digits));
                            if (faBatch_detail_aa_twofold.Insert(control_sample))
                            {
                                oBatch.Has_sample_control = true;
                                new CBatchFactory().Update(oBatch);
                            }

                            // --- search batch to sample
                            SaveInBatch(oBatch_detail_aa_twofold, user);
                        }
                    }
                    else // --- index_mri = 0; entonces la bandeja no lleva mri
                    {                                   
                        oBatch_detail_aa_twofold.Idbatch = idbatch;
                        faBatch_detail_aa_twofold.Insert(oBatch_detail_aa_twofold);
                        SaveRetest(idbatch);

                    }
                }
                else
                {
                    oBatch_detail_aa_twofold.Idbatch = idbatch;
                    faBatch_detail_aa_twofold.Insert(oBatch_detail_aa_twofold);
                    SaveRetest(idbatch);
                }
            }
        }

        private void SaveRetest(long destiny_batch)
        {
            if (Enabled_retest)
            {
                oRetest.Destiny_batch = destiny_batch;
                CRetestFactory faRetest = new CRetestFactory();
                faRetest.Insert(oRetest);
            }
        }
        
        private long? GetBatchAvailable(int idtemplate_method, string user, long origin_batch)
        {
            long? idbatch = GetBatchAvailable(idtemplate_method, false, user, origin_batch);
            return idbatch;
        }

        public long? GetNewBatch(int idtemplate_method, string user, long origin_batch)
        {
            long? idbatch = GetBatchAvailable(idtemplate_method, true, user, origin_batch);
            return idbatch;
        }

        private int GetNumFreePlacesInBatch(long idbatch, int idtemplate_method)
        {
            List<CBatch_detail_aa_twofold> lst = new CBatch_detail_aa_twofoldFactory().GetAll().Where(c => c.Idbatch == idbatch).ToList();
            Methods oMethods = new Methods();
            CTemplate_method_aa template_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));            
            return Convert.ToInt32(template_method_aa.Limit_samples) - lst.Count;
        }

        private long GetIndexMriPredecessor(long idbatch, long incoming_sample)
        {
            List<CBatch_detail_aa_twofold> lst = new CBatch_detail_aa_twofoldFactory().GetAll().Where(c => c.Idbatch == idbatch).ToList();
            long cod_interno = incoming_sample;
            long index_result = 0;
            
            if (lst.Count > 0)
                cod_interno = Convert.ToInt64(lst[0].Cod_interno);

            for (long i = cod_interno; i < incoming_sample; i++)
            {
                if (i % 15 == 6)
                {
                    index_result = i;
                    break;
                }
            }
            return index_result;
        }        
      
        private long GetIndexMriPosition(long idbatch)
        {
            List<CBatch_detail_aa_twofold> lst = new CBatch_detail_aa_twofoldFactory().GetAll().Where(c => c.Idbatch == idbatch).ToList();
            if (lst.Count > 0)
            {
                long min_cod_interno = Convert.ToInt64(lst.Min(c=> c.Cod_interno));
                long max_cod_interno = Convert.ToInt64(lst.Max(c=> c.Cod_interno));
                
                for (long i = min_cod_interno; i < max_cod_interno + 15; i++)
                {
                    if (i % 15 == 6)
                        return i;
                }
            }
            return 0;
        }

        private void InsertBatch(LinkedListNode<CBatch> node, CBatch_detail_aa_twofold sample)
        {            
            if (node != null)
            {
                if (node.Next == null)
                {
                    CBatch batch = node.Value;
                    List<CBatch_detail_aa_twofold> lst_tmp_samples = new List<CBatch_detail_aa_twofold>();

                    // --- seleccionar la lista de muestras del batch
                    CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
                    List<CBatch_detail_aa_twofold> lst_samples =
                        new List<CBatch_detail_aa_twofold>(
                            faBatch_detail_aa_twofold.GetAll()
                            .Where(c => c.Idbatch == batch.Idbatch))
                            .OrderBy(c => c.Cod_interno).ToList();

                    // --- asignar nuevo idbatch a la muestra entrante
                    sample.Idbatch = batch.Idbatch;
                    faBatch_detail_aa_twofold.Update(sample);
                }
                else if (node.Next != null)
                {
                    CBatch batch = node.Value;
                    List<CBatch_detail_aa_twofold> lst_tmp_samples = new List<CBatch_detail_aa_twofold>();

                    // --- seleccionar la lista de muestras del batch
                    CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
                    List<CBatch_detail_aa_twofold> lst_samples =
                        new List<CBatch_detail_aa_twofold>(
                            faBatch_detail_aa_twofold.GetAll()
                            .Where(c => c.Idbatch == batch.Idbatch))
                            .OrderBy(c => c.Cod_interno).ToList();

                    // --- asignar nuevo idbatch a la muestra entrante
                    sample.Idbatch = batch.Idbatch;
                    faBatch_detail_aa_twofold.Update(sample);

                    // --- calcular el índice de la muestra a insertar                        
                    int i = lst_samples.Count - 1;

                    if (lst_samples[i].Flag_mri == 1)
                        i = i - 1;

                    CBatch_detail_aa_twofold sample_out = lst_samples[i];

                    // --- quitar la dirección del batch de la muestra saliente
                    sample_out.Idbatch = null;
                    faBatch_detail_aa_twofold.Update(sample_out);

                    InsertBatch(node.Next, sample_out);
                }

            }
        }        

        public void MoveToExistBatch(List<CBatch> lst, CBatch_detail_aa_twofold sample)
        {
            LinkedList<CBatch> linked_list = new LinkedList<CBatch>(lst);
            InsertBatch(linked_list.First, sample);
        }

        public bool InterchangeSample(CBatch_detail_aa_twofold sample_drag, CBatch_detail_aa_twofold sample_drop)
        {
            long? idbatch_tmp = sample_drag.Idbatch;
            sample_drag.Idbatch = sample_drop.Idbatch;
            sample_drop.Idbatch = idbatch_tmp;

            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
            bool result_drag = faBatch_detail_aa_twofold.Update(sample_drag);
            bool result_drop = faBatch_detail_aa_twofold.Update(sample_drop);
            return result_drag && result_drop;
        }

        public long? GetBatchAvailable(int p_idtemplate_method, bool p_flag_new, string p_user, long p_idbatch_origin)
        {
            #region codigo anterior
            ///TODO
            /*
                        CREATE OR REPLACE FUNCTION public.sp_GetBatchAvailable(p_idtemplate_method int4, p_flag_new boolean, p_user varchar, p_idbatch_origin bigint)
             returns int4
            AS $$	
	            Declare v_NullIdBatch bigint;
	            Declare v_idbatch bigint;
	            declare v_name_batch varchar(30);
	            declare v_num_tray bigint;
	            declare v_status_batch bpchar;
	            declare v_mri_value numeric(10,6);
	            declare v_cod_module varchar;
	            declare v_cod_process varchar;
	            declare v_cod_area varchar;
	            declare v_status_process char(1);
	            declare v_NullIdTraceBatch bigint;
	            declare v_date_out timestamp;
	            declare v_trace_prev bigint;
	            declare v_trace_next bigint;
	            declare v_observation varchar;
	            declare v_user varchar;
	            declare v_date_in timestamp;
            BEGIN	
	            -- get the current batch of template method
	
	            v_NullIdBatch = 0;
	            v_num_tray = COALESCE((SELECT MAX(num_tray)
				            FROM batch
				            ), 0)+1;
				
	            v_idbatch = 0;
	            v_cod_module = 'M002';
	            v_cod_process = 'P013';
	            v_cod_area = 'A004';
	            v_status_process = 'W';
	            v_date_out = null;
	            v_trace_prev = null;
	            v_trace_next = null;
	            v_observation = null;
	            v_user = null;
	            v_date_in = current_timestamp;

	            -- 
	            SELECT INTO v_idbatch COALESCE(A.idbatch, 0)
	            FROM (SELECT DISTINCT t1.idbatch, t2.idrecep_sample_detail, 
			            t2.idtemplate_method, t3.limit_samples
		            FROM batch t1
			            INNER JOIN batch_detail_aa_twofold t2 on t1.idbatch = t2.idbatch
			            INNER JOIN template_method t3 on t1.idtemplate_method = t3.idtemplate_method
		            WHERE t1.cod_process = v_cod_process 
			            AND t1.idtemplate_method = p_idtemplate_method
			            AND t1.idbatch <> p_idbatch_origin
			            AND t1.status_process = v_status_process) A
	            GROUP BY A.idbatch, A.limit_samples
	            HAVING count(*) < A.limit_samples;

	            -- get one name for the batch
	            SELECT INTO v_name_batch, v_mri_value t3.abbreviation, t2.nominal_value
	            FROM template_method_aa t1
		            INNER JOIN mr_detail t2
			            ON t1.idmr_detail = t2.idmr_detail
				            AND t1.idtemplate_method = p_idtemplate_method
		            INNER JOIN template_method t3
			            ON t1.idtemplate_method = t3.idtemplate_method
	            WHERE t1.idtemplate_method = p_idtemplate_method;

	            IF (p_flag_new = true) THEN
		            -- create a new batch
		            v_idbatch  = (SELECT public.sp_batch_Insert(v_NullIdBatch,v_name_batch,v_num_tray,p_idtemplate_method,v_cod_module,v_cod_process,v_cod_area,v_status_process,true,v_mri_value, '', v_date_out, p_user, false));

		            -- save trace
		            -- antes de insertar, si es ultima muestra y contiene mri no insertar
		
		            PERFORM public.sp_trace_batch_insert(v_NullIdTraceBatch, v_cod_module, v_cod_process, v_cod_area, v_idbatch, v_date_in, v_date_out, v_status_process, v_trace_prev, v_trace_next, v_observation, p_user, v_date_in, v_user, v_date_in, true);
	            ELSE
		            -- create new batch, if not exists batch in wait
		            IF (v_idbatch = 0 or v_idbatch is null)
		            THEN			
			            -- create a new batch
			            v_idbatch = (SELECT public.sp_batch_Insert(v_NullIdBatch, v_name_batch, v_num_tray, p_idtemplate_method, v_cod_module, v_cod_process, v_cod_area, v_status_process, true, v_mri_value, '', v_date_out, p_user, false));			

			            -- save trace
			            PERFORM public.sp_trace_batch_insert(v_NullIdTraceBatch, v_cod_module, v_cod_process, v_cod_area, v_idbatch, v_date_in, v_date_out, v_status_process, v_trace_prev, v_trace_next, v_observation, p_user, v_date_in, v_user, v_date_in, true);
		            END IF;
	            END IF;
	            return v_idbatch;
	
            END;*/

            #endregion 

            var query =
                (from m in new CBatchFactory()
                     .GetAll()
                     .Where(x=> x.Idbatch != p_idbatch_origin 
                            && x.Idtemplate_method == p_idtemplate_method
                            && x.Status_process == 'W')
                 from n in new CBatch_detail_aa_twofoldFactory().GetAll().Where(x=> x.Idbatch == m.Idbatch)
                 from p in new CTemplate_methodFactory().GetAll().Where(x=> x.Idtemplate_method == m.Idtemplate_method)
                 from q in new CTemplate_method_aaFactory().GetAll().Where(x=> x.Idtemplate_method == m.Idtemplate_method)
                 select new 
                 { m.Idbatch, n.Idrecep_sample_detail, n.Idtemplate_method, q.Limit_samples }).ToList();

            var query2 =
                (from m in query
                 group m by new { m.Idbatch, m.Limit_samples }
                     into grp
                     where grp.Count() < grp.Key.Limit_samples
                     select new
                     {
                         Idbatch = grp.Key == null ? 0 : grp.Key.Idbatch
                     }).ToList();

            var query3 =
                (from m in new CTemplate_method_aaFactory().GetAll().Where(x=> x.Idtemplate_method == p_idtemplate_method)
                 join n in new CMr_detailFactory().GetAll() on  m.Idmr_detail equals n.Idmr_detail
                 join p in new CTemplate_methodFactory().GetAll() on m.Idtemplate_method equals p.Idtemplate_method
                 select new 
                 {
                     name_batch = p.Abbreviation,
                     mri_value = n.Nominal_value
                 }).ToList();

            string name_batch = query3.FirstOrDefault().name_batch;
            decimal? mri_value = query3.FirstOrDefault().mri_value; 
            long? num_tray = new CBatchFactory().GetAll().Max(x=> x.Num_tray) == null ? 0 : 1;

            long? idbatch = null;
            if (p_flag_new)
            {
                
                
                //save batch
                CBatch batch = new CBatch()
                {
                    Num_tray = num_tray,
                    Idtemplate_method = p_idtemplate_method, 
                    Cod_module = "M002",
                    Cod_process = "P013",
                    Cod_area = "A004",
                    Status_process = 'W',
                    Status = true,
                    Mri_value = mri_value,
                    Description = "",
                    Date_creation_tray = null,
                    User_creation_tray = p_user,
                    Has_sample_control = true
                };

                new CBatchFactory().Insert(batch);
                idbatch = batch.Idbatch;

                //save trace
                CTrace_batch trace_batch = new CTrace_batch()
                {
                    Cod_module = "M002",
                    Cod_process = "P013",
                    Cod_area = "A004",
                    Idbatch = batch.Idbatch,
                    Date_in = DateTime.Now,                    
                    Status_process = 'W',                    
                    Usernew = p_user,
                    Useredit = p_user,
                    Status = true
                };                
            }
            else
            {
                if (idbatch == null || idbatch == 0)
                {
                    CBatch batch = new CBatch()
                    {
                        Name_batch = name_batch,
                        Num_tray = num_tray,
                        Idtemplate_method = p_idtemplate_method,
                        Cod_module = "M002",
                        Cod_process = "P013",
                        Cod_area = "A004",
                        Status_process = 'W',
                        Status = true,
                        Mri_value = mri_value,
                        Description = "",
                        Date_creation_tray = null,
                        User_creation_tray = p_user,
                        Has_sample_control = false
                    };

                    new CBatchFactory().Insert(batch);
                    idbatch = batch.Idbatch;

                    //save trace
                    CTrace_batch trace_batch = new CTrace_batch()
                    {
                        Cod_module = "M002",
                        Cod_process = "P013",
                        Cod_area = "A004",
                        Idbatch = batch.Idbatch,
                        Date_in = DateTime.Now, 
                        Status_process = 'W',                    
                        Usernew = p_user,
                        Useredit = p_user,
                        Status = true
                    }; 
                }		           
            }
            return idbatch;                             
        }
        
    }

    public class Something
    {
        public int id { get; set; }
        public int num { get; set; }
    }
}
