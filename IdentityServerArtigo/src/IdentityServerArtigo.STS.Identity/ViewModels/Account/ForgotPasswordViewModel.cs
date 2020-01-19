﻿using System.ComponentModel.DataAnnotations;

namespace IdentityServerArtigo.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
