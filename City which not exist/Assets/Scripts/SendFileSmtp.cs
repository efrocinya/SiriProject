using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using SimpleFileBrowser;
public class SendFileSmtp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public InputField _input;
    public void onChooseButton()
    {
        StartCoroutine(SendMail("renat1998@yandex.ru",_input.text));
    }
    IEnumerator SendMail(string endEmail = "renat1998@yandex.ru", string modelname = "Исаакиевский собор")
    {
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("siri.ar.city@gmail.com");
        mail.To.Add(endEmail);
        mail.Subject = "Model to Siri";
        mail.Body = modelname;
        System.Net.Mail.Attachment attachment;
        string path = "";
        yield return FileBrowser.WaitForLoadDialog(false, null, "Load File", "Load");
        if (FileBrowser.Success)
        {
            path = FileBrowser.Result;
            attachment = new Attachment(path);
            mail.Attachments.Add(attachment);
        }
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential("siri.ar.city@gmail.com", "51170032") as ICredentialsByHost;
        smtpServer.EnableSsl = true;

        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);
        Debug.Log("success");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
