using lab6_task4;

List<Inotification> notification = new List<Inotification>
{
    new email(),
    new sms(),
    new push(),
    new whatsapp()
};

notificationservice service = new notificationservice();

service.sendnotification(notification, "Hello, this is a test notification!");