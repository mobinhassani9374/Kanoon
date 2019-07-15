using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.DomainModels.Entities
{
    public class Heiat : BaseEntity
    {
        /// <summary>
        /// نام هییت
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// تاریخ تاسیس
        /// </summary>
        public string EstablishedYear { get; set; }


        /// <summary>
        /// شماره ثبت
        /// </summary>
        public int RegistrationNumber { get; set; }

        /// <summary>
        /// محل ثبت
        /// </summary>
        public string RegistrationLocation { get; set; }


        /// <summary>
        /// نام مسیول هییت
        /// </summary>
        public string ManagerName { get; set; }

        /// <summary>
        /// شماره تماس مسیول هییت
        /// </summary>
        public string ManagerPhoneNumber { get; set; }

        /// <summary>
        /// شماره تماس یکی از امنا
        /// </summary>
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// اعضای هییت امنا
        /// </summary>
        public string ContactNames { get; set; }

        /// <summary>
        /// مسیول رسانه
        /// </summary>
        public string MediaManagerFullName { get; set; }

        /// <summary>
        ///- شمراه تماس مسیول رسانه
        /// </summary>
        public string MediaManagerPhoneNumber { get; set; }

        /// <summary>
        /// نحوه شکل گیری - محله ای
        /// </summary>
        public bool IsLocal { get; set; }


        /// <summary>
        /// نحوه شکل گیری - قومیتی
        /// </summary>
        public bool IsEthnicity { get; set; }

        /// <summary>
        /// نحوه شکل گیری - صنفی
        /// </summary>
        public bool IsGuild { get; set; }

        /// <summary>
        /// نحوه شکل گیری - صنفی
        /// </summary>
        public bool IsOfficial { get; set; }

        /// <summary>
        /// نحوه عزاداری - سینه زنی
        /// </summary>
        public bool IsBreastplate { get; set; }

        /// <summary>
        /// نحوه عزاداری - زنجیر زنی
        /// </summary>
        public bool IsChainsaw { get; set; }

        /// <summary>
        /// نحوه عزاداری - تعزیه خوانی
        /// </summary>
        public bool IsPassionReading { get; set; }

        /// <summary>
        /// نحوه عزاداری - شبیه خوانی
        /// </summary>
        public bool IsResemblance { get; set; }

        /// <summary>
        /// نحوه عزاداری - و یا
        /// </summary>
        public string AndOther { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - هفتگی
        /// </summary>
        public bool IsWeekly { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - روز هفته
        /// </summary>
        public string WeekDay { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - ماهانه
        /// </summary>
        public bool IsMonthly { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - روز ماه
        /// </summary>
        public string MonthDay { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - سالانه
        /// </summary>
        public bool IsYearly { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - روز سال
        /// </summary>
        public string YearDay { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - ماسبتی
        /// </summary>
        public bool IsDeally { get; set; }

        /// <summary>
        //زمانبندی و شرح اجرای برنامه - قرآت
        /// </summary>
        public bool IsQuran { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - دعا
        /// </summary>
        public bool IsPray { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - نام دعا
        /// </summary>
        public string PrayName { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - دارای سخنران
        /// </summary>
        public bool IsShokhanran { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - دارای مداحی
        /// </summary>
        public bool IsEagerness { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - دارای پذیرایی
        /// </summary>
        public bool IsCatering { get; set; }

        /// <summary>
        /// زمانبندی و شرح اجرای برنامه - ویا
        /// </summary>
        public bool AndOtherSchedule { get; set; }

        /// <summary>
        /// نحوه اطلاع رسانی - شماره سامانه پیامکی
        /// </summary>
        public string SMSSystemNumber { get; set; }

        /// <summary>
        /// نحوه اطلاع رسانی - آدرس سایت
        /// </summary>
        public string SiteAddress { get; set; }

        /// <summary>
        /// نحوه اطلاع رسانی - آدرس تلگرام
        /// </summary>
        public string TelegramAddress { get; set; }

        /// <summary>
        /// نحوه اطلاع رسانی - آدرس اینستاگرام
        /// </summary>
        public string InstagramAddress { get; set; }

        /// <summary>
        /// نحوه اطلاع رسانی - دارای تابلوی اطلاع رسانی
        /// </summary>
        public bool IsNotificationBar { get; set; }

        /// <summary>
        /// مجریان برنامه - قاری
        /// </summary>
        public string Qhari { get; set; }

        /// <summary>
        /// مجریان برنامه - سخنران
        /// </summary>
        public string Sokhanran { get; set; }

        /// <summary>
        /// مجریان برنامه - مداح
        /// </summary>
        public string Maddah { get; set; }

        /// <summary>
        /// مجریان برنامه - برنامه ویژه
        /// </summary>
        public string SpecialApp { get; set; }

        /// <summary>
        /// آمار مستمعین - برادران
        /// </summary>
        public bool Brothers { get; set; }

        /// <summary>
        /// آمار مستمعین - خواهران
        /// </summary>
        public bool Sisters { get; set; }

        /// <summary>
        /// آمار مستمعین - میزان جمعیت تقریبی
        /// </summary>
        public int ApproximatePopulation { get; set; }

        /// <summary>
        /// آمار مستمعین - میزان جمعیت در ویژه برنامه
        /// </summary>
        public int PopulationsInSpecialProgram { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - ثابت
        /// </summary>
        public bool Const { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - سیار
        /// </summary>
        public bool Mobile { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - مسجد
        /// </summary>
        public bool Mosque { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - حسینیه
        /// </summary>
        public bool Husseinieh { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - ساختمان خصوصی
        /// </summary>
        public bool PrivateBuilding { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - فضای عمومی موقت
        /// </summary>
        public bool TemporaryPublicSpace { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - به متراژ کل
        /// </summary>
        public int TotalArea { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - متراژ برادران
        /// </summary>
        public int TotalBrother { get; set; }

        /// <summary>
        /// مشخصات مکان برگزاری جلسه - متراژ خواهران
        /// </summary>
        public int TotalSister { get; set; }

        /// <summary>
        /// نحوه جذب منابع - کمک های مردمی
        /// </summary>
        public bool PopularSupport { get; set; }

        /// <summary>
        /// نحوه جذب منابع -  بودجه ثابت سازمان یا اداره
        /// </summary>
        public bool FixedBudgetOrganizationOrOffice { get; set; }

        /// <summary>
        /// نحوه جذب منابع -  بودجه ثابت سازمان یا اداره
        /// </summary>
        public bool EconomicActivitiesInTheField { get; set; }

        /// <summary>
        /// فعالیت های جانبی - اردویی
        /// </summary>
        public string TheCamp { get; set; }

        /// <summary>
        /// فعالیت های جانبی - فرهنگی
        /// </summary>
        public string Cultural { get; set; }

        /// <summary>
        /// فعالیت های جانبی - آموزشی
        /// </summary>
        public string Educational { get; set; }

        /// <summary>
        /// فعالیت های جانبی - خیریه 
        /// </summary>
        public string Charity { get; set; }

        /// <summary>
        /// فعالیت های جانبی - سایر
        /// </summary>
        public string Others { get; set; }

        /// <summary>
        /// موقعیت مکان - منطقه
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// موقعیت مکان - ناحیه
        /// </summary>
        public string LocArea { get; set; }
        /// <summary>
        /// موقعیت مکان - محله
        /// </summary>
        public string TheNeighbourhood { get; set; }
        /// <summary>
        /// موقعیت مکان - خیابان اصلی
        /// </summary>
        /// <summary>
        /// موقعیت مکان - منطقه
        /// </summary>
        public string TheMainStreet { get; set; }

        /// <summary>
        /// موقعیت مکان - خیابان فرعی
        /// </summary>
        /// </summary>
        public string AuxiliaryRoad { get; set; }

        /// <summary>
        /// موقعیت مکان - کوچه
        /// </summary>
        /// </summary>
        public string Alley { get; set; }

        /// <summary>
        /// موقعیت مکان - پلاک
        /// </summary>
        /// </summary>
        public string Plaque { get; set; }

        /// <summary>
        /// موقعیت مکان - پلاک
        /// </summary>
        /// </summary>
        public string EssentialRequirementsOfTheBoard { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

    }
}
