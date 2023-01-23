
using Mailing;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddRazorPages();
app.MapRazorPages();
 
//LinkGenerator links = app.Services.GetRequiredService<LinkGenerator>();
 
 




app.MapGet("/", () => "Hello World!");
 
 
app.MapGet("/register/{username}", RegisterUser);
 

app.MapGet("/links", (LinkGenerator links) =>
{
    string link = links.GetPathByName("products");
    return $"View the product at {link}";
});

app.Run();
 
/*string RegisterUser(string username)
{
    var emailSender = new EmailSender();
    emailSender.SendEmail(username);
    return $"Email sent to {username}!";
}
*/


string RegisterUser(string username)
{
    var emailSender = new EmailSender(
        new MessageFactory(),
        new NetworkClient(
            new EmailServerSettings
            (
                Host: "smtp.server.com",
                Port: 25
            ))
        );
    emailSender.SendEmail(username);
    return $"Email sent to {username}!";
}




string RegisterUser(string username, EmailSender emailSender)
{
    emailSender.SendEmail(username);
    return $"Email sent to {username}!";
}



string RegisterUser(string username, IEmailSender emailSender)
{
    emailSender.SendEmail(username);
    return $"Email sent to {username}!";
}

app.Run();
