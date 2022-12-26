using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
smtp.EnableSsl = true;

Console.WriteLine("Введите адрес почты, с которого будет отправлено письмо");
string mailFrom = ReadMail();

Console.WriteLine("Введите пароль от почты(пароль приложений)");
var password = Console.ReadLine();
smtp.Credentials = new NetworkCredential(mailFrom, password);

Console.WriteLine("Введите адрес почты, на который будет отправлено письмо");
string mailTo = ReadMail();

Console.WriteLine("Введите сообщение");
var message = Console.ReadLine();
if (message != null)
{
    var mailMessage = new MailMessage(
        mailFrom,
        mailTo,
        "Тестовое сообщение",
        message
    );

    try
    {
        smtp.Send(mailMessage);
        Console.WriteLine("Сообщение отправлено");
    }
    catch (Exception e)
    {
        Console.WriteLine("Произошла ошибка при отправке сообщения");
        Console.WriteLine(e.Message);
    }
}

static string ReadMail()
{
    Regex emailRegex = new Regex("""(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])""");
    while (true)
    {
        var mail = Console.ReadLine();

        if (mail != null && emailRegex.IsMatch(mail))
        {
            return mail;
        }
    
        Console.WriteLine("Некорректный email, попробуйте еще раз");
    }
}