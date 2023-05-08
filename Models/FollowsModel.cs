﻿using Microsoft.EntityFrameworkCore;

namespace SocialMediaApp.Models
{
    public class FollowsModel
    {
        public string? FollowingUserId { get; set; }
        public string? FollowedUserId { get; set; }
        public DateTime FollowsData { get; set; }
    }
}
