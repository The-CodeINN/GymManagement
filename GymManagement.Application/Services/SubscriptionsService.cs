﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class SubscriptionsService : ISubscriptionService
    {
        public Guid CreateSubscription(string subscriptionType, Guid adminId)
        {
            return Guid.NewGuid(); 
        }
    }
}