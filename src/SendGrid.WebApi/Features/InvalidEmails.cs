﻿using SendGrid.WebApi.Internal;

namespace SendGrid.WebApi.Features
{
    public class InvalidEmails : WebApiBase
    {
        public InvalidEmails(Account account)
            : base(account)
        {
        }
    }
}
