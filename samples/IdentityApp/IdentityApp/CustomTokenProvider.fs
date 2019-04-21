module CustomTokenProviders
open System
open Microsoft.AspNetCore.Identity
open Microsoft.AspNetCore.DataProtection
open Microsoft.Extensions.Options



//type DataProtectorTokenProvider<'T>(dpp, options) = class end
//type DataProtectionTokenProviderOptions() = class end

type CustomEmailConfirmationTokenProvider<'TUser when 'TUser : not struct>(dataProtectionProvider, options) =
    inherit DataProtectorTokenProvider<'TUser>(dataProtectionProvider, options)

type EmailConfirmationTokenProviderOptions() =
    inherit DataProtectionTokenProviderOptions()

    member __.Name = "EmailDataProtectorTokenProvider"
    member __.TokenLifespan = TimeSpan.FromMinutes(5.0)
        