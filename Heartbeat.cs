using CommunityToolkit.WinUI.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppTimers
{
    public class Heartbeat
    {
        private static System.Timers.Timer aTimer;
        public Heartbeat()
        {
            aTimer = new System.Timers.Timer(10000);

            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Set the Interval to 2 seconds (2000 milliseconds).
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
        }

        public void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            NotifyIcon notifyIcon = new NotifyIcon();

            double Timer = Convert.ToDouble(e.SignalTime.ToString("yyyyMMddHHmmss"));
            double TimerDD = Convert.ToDouble(e.SignalTime.ToString("yyyyMMdd"));

            foreach (var Data in db.GetData())
            {

                double ss = Convert.ToDouble(Data.Date.ToString("yyyyMMddHHmmss"));
                double DD = Convert.ToDouble(Data.Date.ToString("yyyyMMdd"));
                if (Timer == ss)
                {
                    var Azkar = Path.GetFullPath(@"Images\Azkar.jpg");
                    var Azkars = Path.GetFullPath(@"Images\Azkars.jpg");
                    notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText(Data.Title)
                        .AddText(Data.Text)
                        .AddInlineImage(new Uri(Azkars))
                       .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                       .Show();
                    /*
                    int Hours = Convert.ToInt32(Data.Date.ToString("h"));
                    switch (Hours)
                    {
                        case 1:
                            string azkar1 = "سُبْحَانَ اللَّهِ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar1)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;
                        case 2:
                            string azkar2 = "سُبْحَانَ اللَّهِ وَبِحَمْدِهِ  ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar2)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;

                        case 3:
                            string azkar3 = "سُبْحَانَ اللَّهِ وَالْحَمْدُ لِلَّهِ . ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar3)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;
                        case 4:
                            string azkar4 = "سُبْحَانَ اللهِ العَظِيمِ وَبِحَمْدِهِ . ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar4)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;
                        case 5:
                            string azkar5 = "سُبْحَانَ اللَّهِ وَبِحَمْدِهِ ، سُبْحَانَ اللَّهِ الْعَظِيمِ .";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar5)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;
                        case 6:
                            string azkar6 = @"لَا إلَه إلّا اللهُ وَحْدَهُ لَا شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلُّ شَيْءِ قَدِيرِ.  لا حَوْلَ وَلا قُوَّةَ إِلا بِاللَّهِ ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar6)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;

                        case 7:
                            string azkar7 = "الْحَمْدُ للّهِ رَبِّ الْعَالَمِينَ ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar7)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;
                        case 8:
                            string azkar8 = "اللَّهُمَّ صَلِّ عَلَى مُحَمَّدٍ وَعَلَى آلِ مُحَمَّدٍ كَمَا صَلَّيْتَ عَلَى إِبْرَاهِيمَ , وَعَلَى آلِ إِبْرَاهِيمَ إِنَّكَ حَمِيدٌ مَجِيدٌ , اللَّهُمَّ بَارِكْ عَلَى مُحَمَّدٍ وَعَلَى آلِ مُحَمَّدٍ كَمَا بَارَكْتَ عَلَى إِبْرَاهِيمَ وَعَلَى آلِ إِبْرَاهِيمَ إِنَّكَ حَمِيدٌ مَجِيدٌ. " + "الْلَّهُم صَلِّ وَسَلِم وَبَارِك عَلَى سَيِّدِنَا مُحَمَّد ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar8)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            break;
                        case 9:
                            string azkar9 = "الْلَّهُ أَكْبَرُ" + "لَا إِلَهَ إِلَّا اللَّهُ " + "أستغفر الله.";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar9)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();

                            break;
                        case 10:
                            string azkar10 = "سُبْحَانَ الْلَّهِ، وَالْحَمْدُ لِلَّهِ، وَلَا إِلَهَ إِلَّا الْلَّهُ، وَالْلَّهُ أَكْبَرُ  ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar10)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();


                            break;

                        case 11:
                            string azkar11 = "سُبْحَانَ اللَّهِ ، وَالْحَمْدُ لِلَّهِ ، وَلا إِلَهَ إِلا اللَّهُ ، وَاللَّهُ أَكْبَرُ ، اللَّهُمَّ اغْفِرْ لِي ، اللَّهُمَّ ارْحَمْنِي ، اللَّهُمَّ ارْزُقْنِي.  ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar11)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();


                            break;
                        case 12:
                            string azkar12 = "الْحَمْدُ لِلَّهِ حَمْدًا كَثِيرًا طَيِّبًا مُبَارَكًا فِيهِ. .";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, Data.Text + " " + Data.Date.ToString(), ToolTipIcon.Info);
                            new ToastContentBuilder()
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar12)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();

                            break;
                        

                        default:
                            break;
                   
                    }
*/
                } 
                else
                {
                    Console.WriteLine("No ok");
                }


            }

            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }


        public void Start()
        {
            aTimer.Start();
        }
        public void Stop()
        {
            aTimer.Stop();
        }

    }
}
