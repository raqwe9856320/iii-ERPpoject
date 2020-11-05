//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIP_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tEmployee()
        {
            this.tApplypunches = new HashSet<tApplypunch>();
            this.tBillboards = new HashSet<tBillboard>();
            this.tCalendars = new HashSet<tCalendar>();
            this.tMetting_date = new HashSet<tMetting_date>();
            this.tNotifies = new HashSet<tNotify>();
            this.tProjects = new HashSet<tProject>();
            this.tProjectDetails = new HashSet<tProjectDetail>();
            this.tPunchtimes = new HashSet<tPunchtime>();
            this.tSignoffs = new HashSet<tSignoff>();
            this.tTeamMembers = new HashSet<tTeamMember>();
            this.tTimeRecords = new HashSet<tTimeRecord>();
            this.tLeavecounts = new HashSet<tLeavecount>();
            this.tLeaves = new HashSet<tLeave>();
            this.tOvertimes = new HashSet<tOvertime>();
        }

        [DisplayName("員工編號")]
        public int fEmployeeId { get; set; }
        [DisplayName("員工姓名")]
        [Required(ErrorMessage = "此欄為必填")]
        public string fName { get; set; }
        [DisplayName("身分證號")]
        [Required(ErrorMessage = "此欄為必填")]
        public string fIdent { get; set; }
        [DisplayName("密碼")]
        [Required(ErrorMessage = "此欄為必填")]

        public string fPassword { get; set; }
        [DisplayFormat(DataFormatString = "", ApplyFormatInEditMode = true)]
        [DisplayName("部門")]
        [Required(ErrorMessage = "此欄為必填")]

        public string fDepartment { get; set; }
        [DisplayName("職稱")]
        [Required(ErrorMessage = "此欄為必填")]

        public string fTitle { get; set; }
        [DisplayName("信箱")]
        [Required(ErrorMessage = "此欄為必填")]

        public string fEmail { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("生日")]
        [Required(ErrorMessage = "此欄為必填")]

        public System.DateTime fBirth { get; set; }
        [DisplayName("手機號碼")]
        [Required(ErrorMessage = "此欄為必填")]

        public string fPhonePersonal { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("到職日期")]
        [Required(ErrorMessage = "此欄為必填")]


        public System.DateTime fHireDate { get; set; }
        [DisplayName("月薪")]
        [Required(ErrorMessage = "此欄為必填")]


        public int fSalaryMonth { get; set; }
        [DisplayName("時薪")]

        public Nullable<int> fSalaryHour { get; set; }
        [DisplayName("家裡電話")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fPhoneHouse { get; set; }
        [DisplayName("國籍")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fCountry { get; set; }
        [DisplayName("出生地")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fBirthPlace { get; set; }
        [DisplayName("教育程度")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fEducation { get; set; }
        [DisplayName("通訊地址")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fAddressNow { get; set; }
        [DisplayName("戶籍地址")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fAddressOrigin { get; set; }
        [DisplayName("緊急連絡人姓名")]
        [Required(ErrorMessage = "此欄為必填")]
        public string fEngyName { get; set; }
        [DisplayName("緊急連絡人電話")]
        [Required(ErrorMessage = "此欄為必填")]
        public string fEngyPhone { get; set; }
        [DisplayName("年資")]

        public Nullable<double> fOld { get; set; }
        [DisplayName("狀態")]
        [Required(ErrorMessage = "此欄為必填")]


        public string fState { get; set; }
        [DisplayName("權限")]
        [Required(ErrorMessage = "此欄為必填")]


        public int fAuth { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("離職日")]

        public Nullable<System.DateTime> fFireDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("復職日")]

        public Nullable<System.DateTime> fBackDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tApplypunch> tApplypunches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tBillboard> tBillboards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCalendar> tCalendars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tMetting_date> tMetting_date { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tNotify> tNotifies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProject> tProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProjectDetail> tProjectDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tPunchtime> tPunchtimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tSignoff> tSignoffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTeamMember> tTeamMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTimeRecord> tTimeRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tLeavecount> tLeavecounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tLeave> tLeaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOvertime> tOvertimes { get; set; }
    }
}