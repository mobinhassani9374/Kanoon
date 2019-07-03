using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
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
                IsSuccess = false,
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
                IsSuccess = false,
                Message = message
            };
        }

        public static ServiceResult Error(ModelStateDictionary modelState)
        {
            var errors = modelState
                .Select(c => c.Value)
                .Select(c => c.Errors)
                .ToList();

            var errorMessages = errors
                .SelectMany(c => c.Select(i => i.ErrorMessage))
                .ToList();

            var messages = "";

            errorMessages.ForEach(c =>
            {
                messages += $"{c} <br/>";
            });

            return new ServiceResult()
            {
                IsSuccess = false,
                Message = messages
            };
        }
    }
}
