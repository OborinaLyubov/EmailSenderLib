# EmailSenderLib

### Objective of the project
Implementation of a universal library for working with mail for further use in other projects. In library uses standard functionality for working with mail (System.Net.Mail). In the future, it is planned to develop a more current version without using the base library System.Net.Mail.

![Actualise release](https://img.shields.io/github/v/release/OborinaLyubov/EmailSenderLib) ![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/OborinaLyubov/EmailSenderLib) ![GitHub issues](https://img.shields.io/github/issues/OborinaLyubov/EmailSenderLib)

<details>
  
<summary>EmailSender API</summary>

```C#
   MailAddress GetSenderAddress(string host)
``` 
- get current email sender. Parameter: "*host*" - host email server.

```C#
   void Send(MailMessage mailmessage, string host)
```
- send a message to the specified host. Parameters: "*mailMessage*" - prepared message with specified sender and recipient (type - MailMessage), "*host*" - host email sender.

```C#
   MailMessage AddMailMessage(MailAddress senderAddress, string recipientEmail, string subject, string body)
```
- creating a message with subject, message body, sender and recipient. Parameters: "*senderAddress*" - email address sender (type - MailAddress), "*recipientEmail*" - email address recipient, "*subject*" - subject future message, "*body*" - body future message.

```C#
   Regex CreateValidEmailRegex()
```
- get regular expression for check email address.

```C#
   bool IsValidEmailAddress(string email)
```
- check email address by using regular expression. Parameter: "*email*" - email address to check.

</details>

### Installation/Using

1. Download library from latest release (the current release is indicated after the project description).
2. Load the resulting file as an external library into your development project.
