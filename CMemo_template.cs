using System;
using System.Collections.Generic;
using System.Text;
namespace LimsProject.BusinessLayer
{
	public class CMemo_template: BusinessObjectBase
	{

		#region InnerClass
		public enum CMemo_templateFields
		{
			Idmemo_template,
			Paragraph,
			Paragraph_rtf,
			Memo_type
		}
		#endregion

		#region Data Members

			int _idmemo_template;
			string _paragraph;
			string _paragraph_rtf;
			int? _memo_type;

		#endregion

		#region Properties

		public int  Idmemo_template
		{
			 get { return _idmemo_template; }
			 set
			 {
				 if (_idmemo_template != value)
				 {
					_idmemo_template = value;
					 PropertyHasChanged("Idmemo_template");
				 }
			 }
		}

		public string  Paragraph
		{
			 get { return _paragraph; }
			 set
			 {
				 if (_paragraph != value)
				 {
					_paragraph = value;
					 PropertyHasChanged("Paragraph");
				 }
			 }
		}

		public string  Paragraph_rtf
		{
			 get { return _paragraph_rtf; }
			 set
			 {
				 if (_paragraph_rtf != value)
				 {
					_paragraph_rtf = value;
					 PropertyHasChanged("Paragraph_rtf");
				 }
			 }
		}

		public int?  Memo_type
		{
			 get { return _memo_type; }
			 set
			 {
				 if (_memo_type != value)
				 {
					_memo_type = value;
					 PropertyHasChanged("Memo_type");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("Idmemo_template", "Idmemo_template"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Paragraph", "Paragraph",3000));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Paragraph_rtf", "Paragraph_rtf",3000));
		}

		#endregion

	}
}
