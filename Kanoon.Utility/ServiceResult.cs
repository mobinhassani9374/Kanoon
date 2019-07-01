using System;
using System.Collections.Generic;
using System.Text;

namespace Kanoon.Utility
{
    public class ServiceResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public static ServiceResult Okay()
        {
            return new ServiceResult()
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت صورت گرفت"
            };
        }
        public static ServiceResult Error()
        {
            return new ServiceResult()
            {
                IsSuccess = true,
                Message = "در انجام عملیات خطایی رخ داد مجددا تلاش کنید"
            };
        }
        public static ServiceResult Okay(string message)
        {
            return new ServiceResult()
            {
                IsSuccess = true,
                Message = message
            };
        }
        public static ServiceResult Error(string message)
        {
            return new ServiceResult()
            {
                IsSuccess = true,
                Message = message
            };
        }
    }
}
