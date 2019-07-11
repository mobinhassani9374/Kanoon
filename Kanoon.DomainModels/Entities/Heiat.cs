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

    }
}
