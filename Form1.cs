using CommunityToolkit.WinUI.Notifications;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppTimers
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public static int i=0;
        public Form1()
        {
            InitializeComponent();

            aTimer = new System.Timers.Timer(10000);
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            // Set the Interval to 2 seconds (2000 milliseconds).
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            aTimer.Start();
        }

        public void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            NotifyIcon notifyIcon = new NotifyIcon();

            double Timer = Convert.ToDouble(e.SignalTime.ToString("yyyyMMddHHmmss"));

            foreach (var Data in db.GetData())
            {
               
             double ss = Convert.ToDouble(Data.Date.ToString("yyyyMMddHHmmss"));
                if (Timer == ss)
                {
                    //   label2.Text = Data.Text;
                   // var Audio = Path.GetFullPath(@"Audio\Azkar.m4a");
                    var Azkar = Path.GetFullPath(@"Images\Azkar.jpg");
                    var Azkars = Path.GetFullPath(@"Images\Azkars.jpg");
               
                    int Hours =Data.Date.Hour;
                    switch (Hours)
                    {
                        case 0:
                            string azkar0 = "أسْتَغْفِرُ اللهَ العَظِيمَ الَّذِي لاَ إلَهَ إلاَّ هُوَ، الحَيُّ القَيُّومُ، وَأتُوبُ إلَيهِ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title,azkar0 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar0)
                                .AddInlineImage(new Uri(Azkars))
                                .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                                .Show();
                            this.Show();
                            break;
                         case 1:
                            string azkar1 = "اللَّهُمَّ صَلِّ وَسَلِّمْ وَبَارِكْ على نَبِيِّنَا مُحمَّد. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar1 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar1)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;

                        case 2:
                            string azkar2 = "اللّهُـمَّ ما أَصْبَـَحَ بي مِـنْ نِعْـمَةٍ أَو بِأَحَـدٍ مِـنْ خَلْـقِك ، فَمِـنْكَ وَحْـدَكَ لا شريكَ لَـك ، فَلَـكَ الْحَمْـدُ وَلَـكَ الشُّكْـر. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar2 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar2)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 3:
                            string azkar3 = "حَسْبِـيَ اللّهُ لا إلهَ إلاّ هُوَ عَلَـيهِ تَوَكَّـلتُ وَهُوَ رَبُّ العَرْشِ العَظـيم. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar3 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar3)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 4:
                            string azkar4 = "بِسـمِ اللهِ الذي لا يَضُـرُّ مَعَ اسمِـهِ شَيءٌ في الأرْضِ وَلا في السّمـاءِ وَهـوَ السّمـيعُ العَلـيم.";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar4+ " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar4)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 5:
                            string azkar5 = @"
اللّهُـمَّ بِكَ أَصْـبَحْنا وَبِكَ أَمْسَـينا ، وَبِكَ نَحْـيا وَبِكَ نَمُـوتُ وَإِلَـيْكَ النُّـشُور.
أَعُوذُ بِاللهِ مِنْ الشَّيْطَانِ الرَّجِيمِ 
)اللّهُ لاَ إِلَـهَ إِلاَّ هُوَ الْحَيُّ الْقَيُّومُ لاَ تَأْخُذُهُ سِنَةٌ وَلاَ نَوْمٌ لَّهُ مَا فِي السَّمَاوَاتِ وَمَا فِي الأَرْضِ مَن ذَا الَّذِي يَشْفَعُ عِنْدَهُ إِلاَّ بِإِذْنِهِ يَعْلَمُ مَا بَيْنَ أَيْدِيهِمْ وَمَا خَلْفَهُمْ وَلاَ يُحِيطُونَ بِشَيْءٍ مِّنْ عِلْمِهِ إِلاَّ بِمَا شَاء وَسِعَ كُرْسِيُّهُ السَّمَاوَاتِ وَالأَرْضَ وَلاَ يَؤُودُهُ حِفْظُهُمَا وَهُوَ الْعَلِيُّ الْعَظِيمُ).  [آية الكرسى - البقرة 255].
" + "( بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم (قُلْ هُوَ ٱللَّهُ أَحَدٌ، ٱللَّهُ ٱلصَّمَدُ، لَمْ يَلِدْ وَلَمْ يُولَدْ، وَلَمْ يَكُن لَّهُۥ كُفُوًا أَحَدٌۢ." +
"(بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم (قُلْ أَعُوذُ بِرَبِّ ٱلْفَلَقِ، مِن شَرِّ مَا خَلَقَ، وَمِن شَرِّ غَاسِقٍ إِذَا وَقَبَ، وَمِن شَرِّ ٱلنَّفَّٰثَٰتِ فِى ٱلْعُقَدِ، وَمِن شَرِّ حَاسِدٍ إِذَا حَسَدَ." +
"(بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم (قُلْ أَعُوذُ بِرَبِّ ٱلنَّاسِ، مَلِكِ ٱلنَّاسِ، إِلَٰهِ ٱلنَّاسِ، مِن شَرِّ ٱلْوَسْوَاسِ ٱلْخَنَّاسِ، ٱلَّذِى يُوَسْوِسُ فِى صُدُورِ ٱلنَّاسِ، مِنَ ٱلْجِنَّةِ وَٱلنَّاسِ)."+ "أَصْـبَحْنا وَأَصْـبَحَ المُـلْكُ لله وَالحَمدُ لله ، لا إلهَ إلاّ اللّهُ وَحدَهُ لا شَريكَ لهُ، لهُ المُـلكُ ولهُ الحَمْـد، وهُوَ على كلّ شَيءٍ قدير ، رَبِّ أسْـأَلُـكَ خَـيرَ ما في هـذا اليوم وَخَـيرَ ما بَعْـدَه ، وَأَعـوذُ بِكَ مِنْ شَـرِّ ما في هـذا اليوم وَشَرِّ ما بَعْـدَه، رَبِّ أَعـوذُبِكَ مِنَ الْكَسَـلِ وَسـوءِ الْكِـبَر ، رَبِّ أَعـوذُ بِكَ مِنْ عَـذابٍ في النّـارِ وَعَـذابٍ في القَـبْر"
;
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar5 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar5)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;

                        case 6:
                            string azkar6 = "اللّهـمَّ أَنْتَ رَبِّـي لا إلهَ إلاّ أَنْتَ ، خَلَقْتَنـي وَأَنا عَبْـدُك ، وَأَنا عَلـى عَهْـدِكَ وَوَعْـدِكَ ما اسْتَـطَعْـت ، أَعـوذُبِكَ مِنْ شَـرِّ ما صَنَـعْت ، أَبـوءُ لَـكَ بِنِعْـمَتِـكَ عَلَـيَّ وَأَبـوءُ بِذَنْـبي فَاغْفـِرْ لي فَإِنَّـهُ لا يَغْـفِرُ الذُّنـوبَ إِلاّ أَنْتَ .";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar6 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar6)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();


                            break;
                        case 7:
                            string azkar7 = "اللّهـمَّ أَنْتَ رَبِّـي لا إلهَ إلاّ أَنْتَ ، خَلَقْتَنـي وَأَنا عَبْـدُك ، وَأَنا عَلـى عَهْـدِكَ وَوَعْـدِكَ ما اسْتَـطَعْـت ، أَعـوذُبِكَ مِنْ شَـرِّ ما صَنَـعْت ، أَبـوءُ لَـكَ بِنِعْـمَتِـكَ عَلَـيَّ وَأَبـوءُ بِذَنْـبي فَاغْفـِرْ لي فَإِنَّـهُ لا يَغْـفِرُ الذُّنـوبَ إِلاّ أَنْتَ .";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar7 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar7)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 8:
                            string azkar8 = "رَضيـتُ بِاللهِ رَبَّـاً وَبِالإسْلامِ ديـناً وَبِمُحَـمَّدٍ صلى الله عليه وسلم نَبِيّـاً.";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar8 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar8)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 9:
                            string azkar9 = "اللّهُـمَّ إِنِّـي أَصْبَـحْتُ أُشْـهِدُك ، وَأُشْـهِدُ حَمَلَـةَ عَـرْشِـك ، وَمَلَائِكَتَكَ ، وَجَمـيعَ خَلْـقِك ، أَنَّـكَ أَنْـتَ اللهُ لا إلهَ إلاّ أَنْـتَ وَحْـدَكَ لا شَريكَ لَـك ، وَأَنَّ ُ مُحَمّـداً عَبْـدُكَ وَرَسـولُـك. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar9 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar9)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;

                        case 10:
                            string azkar10 = "اللّهُـمَّ عافِـني في بَدَنـي ، اللّهُـمَّ عافِـني في سَمْـعي ، اللّهُـمَّ عافِـني في بَصَـري ، لا إلهَ إلاّ أَنْـتَ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar10 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar10)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 11:
                            string azkar11 = "سُبْحـانَ اللهِ وَبِحَمْـدِهِ عَدَدَ خَلْـقِه ، وَرِضـا نَفْسِـه ، وَزِنَـةَ عَـرْشِـه ، وَمِـدادَ كَلِمـاتِـه.";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar11 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar11)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 12:
                            string azkar12 = "اللّهُـمَّ إِنّـي أَعـوذُ بِكَ مِنَ الْكُـفر ، وَالفَـقْر ، وَأَعـوذُ بِكَ مِنْ عَذابِ القَـبْر ، لا إلهَ إلاّ أَنْـتَ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar12 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar12)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();

                            break;
                        case 13:
                            string azkar13 = "اللّهُـمَّ إِنِّـي أسْـأَلُـكَ العَـفْوَ وَالعـافِـيةَ في الدُّنْـيا وَالآخِـرَة ، اللّهُـمَّ إِنِّـي أسْـأَلُـكَ العَـفْوَ وَالعـافِـيةَ في ديني وَدُنْـيايَ وَأهْـلي وَمالـي ، اللّهُـمَّ اسْتُـرْ عـوْراتي وَآمِـنْ رَوْعاتـي ، اللّهُـمَّ احْفَظْـني مِن بَـينِ يَدَيَّ وَمِن خَلْفـي وَعَن يَمـيني وَعَن شِمـالي ، وَمِن فَوْقـي ، وَأَعـوذُ بِعَظَمَـتِكَ أَن أُغْـتالَ مِن تَحْتـي. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar13 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar13)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                        case 14:
                            string azkar14 = "يَا حَيُّ يَا قيُّومُ بِرَحْمَتِكَ أسْتَغِيثُ أصْلِحْ لِي شَأنِي كُلَّهُ وَلاَ تَكِلْنِي إلَى نَفْسِي طَـرْفَةَ عَيْنٍ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar14 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar14)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                        case 15:
                            string azkar15 = "أَعـوذُ بِكَلِمـاتِ اللّهِ التّـامّـاتِ مِنْ شَـرِّ ما خَلَـق. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar15 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar15)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                        case 16:
                            string azkar16 = "اللَّهُمَّ صَلِّ وَسَلِّمْ وَبَارِكْ على نَبِيِّنَا مُحمَّد. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar16 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar16)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                        case 17:
                            string azkar17 = "اللَّهُمَّ صَلِّ وَسَلِّمْ وَبَارِكْ على نَبِيِّنَا مُحمَّد. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar17 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar17)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                        case 18:
                            string azkar18 = "اللَّهُمَّ إِنَّا نَعُوذُ بِكَ مِنْ أَنْ نُشْرِكَ بِكَ شَيْئًا نَعْلَمُهُ ، وَنَسْتَغْفِرُكَ لِمَا لَا نَعْلَمُهُ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar18 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar18)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;

                        case 19:
                            string azkar19 = "يَا رَبِّ , لَكَ الْحَمْدُ كَمَا يَنْبَغِي لِجَلَالِ وَجْهِكَ , وَلِعَظِيمِ سُلْطَانِكَ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar19 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar19)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                        case 20:
                            string azkar20 = "لَا إلَه إلّا اللهُ وَحْدَهُ لَا شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلِّ شَيْءِ قَدِيرِ. ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar20 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar20)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                     
                        case 21:
                            string azkar21 = "أسْتَغْفِرُ اللهَ وَأتُوبُ إلَيْهِ ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar21 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar21)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break; 
                        case 22:
                            string azkar22 =  "سُبْحَانَ اللهِ العَظِيمِ وَبِحَمْدِهِ ";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar22 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar22)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();

                            this.Show();
                            break;

                        case 23:
                            string azkar23 = "اللَّهُمَّ أَنْتَ رَبِّي لا إِلَهَ إِلا أَنْتَ ، عَلَيْكَ تَوَكَّلْتُ ، وَأَنْتَ رَبُّ الْعَرْشِ الْعَظِيمِ , مَا شَاءَ اللَّهُ كَانَ ، وَمَا لَمْ يَشَأْ لَمْ يَكُنْ ، وَلا حَوْلَ وَلا قُوَّةَ إِلا بِاللَّهِ الْعَلِيِّ الْعَظِيمِ , أَعْلَمُ أَنَّ اللَّهَ عَلَى كُلِّ شَيْءٍ قَدِيرٌ ، وَأَنَّ اللَّهَ قَدْ أَحَاطَ بِكُلِّ شَيْءٍ عِلْمًا , اللَّهُمَّ إِنِّي أَعُوذُ بِكَ مِنْ شَرِّ نَفْسِي ، وَمِنْ شَرِّ كُلِّ دَابَّةٍ أَنْتَ آخِذٌ بِنَاصِيَتِهَا ، إِنَّ رَبِّي عَلَى صِرَاطٍ مُسْتَقِيمٍ.";
                            notifyIcon.ShowBalloonTip(Data.Id, Data.Title, azkar23 + " " + Data.Date.ToString(), ToolTipIcon.Info);// windows 7
                            new ToastContentBuilder() //windows 10 to 11
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText(Data.Title)
                                .AddText(azkar23)
                                .AddInlineImage(new Uri(Azkars))
                               .AddAppLogoOverride(new Uri(Azkar), ToastGenericAppLogoCrop.Circle)
                               .Show();
                            this.Show();
                            break;
                       

                        default:
                            break;
                    }

                   
                }
                else
                {
                    Console.WriteLine("No ok");
                }


            }

            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //label1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            double TimerDD = Convert.ToDouble(DateTime.Now.ToString("yyyyMMdd"));
            foreach (var Data in db.GetData())
            {
                double DD = Convert.ToDouble(Data.Date.ToString("yyyyMMdd"));

                if (TimerDD == DD)
                {
                    // notificationBindingSource.Add(Data);
                }
            }



        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
             //   RegistryKey registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\windows\\CurrentVersion\\Run", true);
             //   registry.SetValue("Azkar", Application.ExecutablePath.ToString());
                this.Hide();






            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text=i.ToString();
            // Hook up the Elapsed event for the timer.

            // Set the Interval to 2 seconds (2000 milliseconds).
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            int Hours = DateTime.Now.Hour;
            switch (Hours)
            {
                case 0:
                    textBox2.Text = "أسْتَغْفِرُ اللهَ العَظِيمَ الَّذِي لاَ إلَهَ إلاَّ هُوَ، الحَيُّ القَيُّومُ، وَأتُوبُ إلَيهِ. ";
        
                    break;
                case 1:
                    textBox2.Text = "اللَّهُمَّ صَلِّ وَسَلِّمْ وَبَارِكْ على نَبِيِّنَا مُحمَّد. ";
              

                    break;

                case 2:
                    textBox2.Text = "اللّهُـمَّ ما أَصْبَـَحَ بي مِـنْ نِعْـمَةٍ أَو بِأَحَـدٍ مِـنْ خَلْـقِك ، فَمِـنْكَ وَحْـدَكَ لا شريكَ لَـك ، فَلَـكَ الْحَمْـدُ وَلَـكَ الشُّكْـر. ";
                 

                    break;
                case 3:
                    textBox2.Text = "حَسْبِـيَ اللّهُ لا إلهَ إلاّ هُوَ عَلَـيهِ تَوَكَّـلتُ وَهُوَ رَبُّ العَرْشِ العَظـيم. ";
                   

                    break;
                case 4:
                    textBox2.Text = "بِسـمِ اللهِ الذي لا يَضُـرُّ مَعَ اسمِـهِ شَيءٌ في الأرْضِ وَلا في السّمـاءِ وَهـوَ السّمـيعُ العَلـيم.";
               

                    break;
                case 5:
                    textBox2.Text = @"
اللّهُـمَّ بِكَ أَصْـبَحْنا وَبِكَ أَمْسَـينا ، وَبِكَ نَحْـيا وَبِكَ نَمُـوتُ وَإِلَـيْكَ النُّـشُور.
أَعُوذُ بِاللهِ مِنْ الشَّيْطَانِ الرَّجِيمِ 
)اللّهُ لاَ إِلَـهَ إِلاَّ هُوَ الْحَيُّ الْقَيُّومُ لاَ تَأْخُذُهُ سِنَةٌ وَلاَ نَوْمٌ لَّهُ مَا فِي السَّمَاوَاتِ وَمَا فِي الأَرْضِ مَن ذَا الَّذِي يَشْفَعُ عِنْدَهُ إِلاَّ بِإِذْنِهِ يَعْلَمُ مَا بَيْنَ أَيْدِيهِمْ وَمَا خَلْفَهُمْ وَلاَ يُحِيطُونَ بِشَيْءٍ مِّنْ عِلْمِهِ إِلاَّ بِمَا شَاء وَسِعَ كُرْسِيُّهُ السَّمَاوَاتِ وَالأَرْضَ وَلاَ يَؤُودُهُ حِفْظُهُمَا وَهُوَ الْعَلِيُّ الْعَظِيمُ).  [آية الكرسى - البقرة 255].
" + "( بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم (قُلْ هُوَ ٱللَّهُ أَحَدٌ، ٱللَّهُ ٱلصَّمَدُ، لَمْ يَلِدْ وَلَمْ يُولَدْ، وَلَمْ يَكُن لَّهُۥ كُفُوًا أَحَدٌۢ." +
"(بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم (قُلْ أَعُوذُ بِرَبِّ ٱلْفَلَقِ، مِن شَرِّ مَا خَلَقَ، وَمِن شَرِّ غَاسِقٍ إِذَا وَقَبَ، وَمِن شَرِّ ٱلنَّفَّٰثَٰتِ فِى ٱلْعُقَدِ، وَمِن شَرِّ حَاسِدٍ إِذَا حَسَدَ." +
"(بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم (قُلْ أَعُوذُ بِرَبِّ ٱلنَّاسِ، مَلِكِ ٱلنَّاسِ، إِلَٰهِ ٱلنَّاسِ، مِن شَرِّ ٱلْوَسْوَاسِ ٱلْخَنَّاسِ، ٱلَّذِى يُوَسْوِسُ فِى صُدُورِ ٱلنَّاسِ، مِنَ ٱلْجِنَّةِ وَٱلنَّاسِ)." + "أَصْـبَحْنا وَأَصْـبَحَ المُـلْكُ لله وَالحَمدُ لله ، لا إلهَ إلاّ اللّهُ وَحدَهُ لا شَريكَ لهُ، لهُ المُـلكُ ولهُ الحَمْـد، وهُوَ على كلّ شَيءٍ قدير ، رَبِّ أسْـأَلُـكَ خَـيرَ ما في هـذا اليوم وَخَـيرَ ما بَعْـدَه ، وَأَعـوذُ بِكَ مِنْ شَـرِّ ما في هـذا اليوم وَشَرِّ ما بَعْـدَه، رَبِّ أَعـوذُبِكَ مِنَ الْكَسَـلِ وَسـوءِ الْكِـبَر ، رَبِّ أَعـوذُ بِكَ مِنْ عَـذابٍ في النّـارِ وَعَـذابٍ في القَـبْر"
;

                    break;

                case 6:
                    textBox2.Text = "اللّهـمَّ أَنْتَ رَبِّـي لا إلهَ إلاّ أَنْتَ ، خَلَقْتَنـي وَأَنا عَبْـدُك ، وَأَنا عَلـى عَهْـدِكَ وَوَعْـدِكَ ما اسْتَـطَعْـت ، أَعـوذُبِكَ مِنْ شَـرِّ ما صَنَـعْت ، أَبـوءُ لَـكَ بِنِعْـمَتِـكَ عَلَـيَّ وَأَبـوءُ بِذَنْـبي فَاغْفـِرْ لي فَإِنَّـهُ لا يَغْـفِرُ الذُّنـوبَ إِلاّ أَنْتَ .";
                 


                    break;
                case 7:
                    textBox2.Text = "اللّهـمَّ أَنْتَ رَبِّـي لا إلهَ إلاّ أَنْتَ ، خَلَقْتَنـي وَأَنا عَبْـدُك ، وَأَنا عَلـى عَهْـدِكَ وَوَعْـدِكَ ما اسْتَـطَعْـت ، أَعـوذُبِكَ مِنْ شَـرِّ ما صَنَـعْت ، أَبـوءُ لَـكَ بِنِعْـمَتِـكَ عَلَـيَّ وَأَبـوءُ بِذَنْـبي فَاغْفـِرْ لي فَإِنَّـهُ لا يَغْـفِرُ الذُّنـوبَ إِلاّ أَنْتَ .";
                  
                    break;
                case 8:
                    textBox2.Text = "رَضيـتُ بِاللهِ رَبَّـاً وَبِالإسْلامِ ديـناً وَبِمُحَـمَّدٍ صلى الله عليه وسلم نَبِيّـاً.";
               

                    break;
                case 9:
                    textBox2.Text = "اللّهُـمَّ إِنِّـي أَصْبَـحْتُ أُشْـهِدُك ، وَأُشْـهِدُ حَمَلَـةَ عَـرْشِـك ، وَمَلَائِكَتَكَ ، وَجَمـيعَ خَلْـقِك ، أَنَّـكَ أَنْـتَ اللهُ لا إلهَ إلاّ أَنْـتَ وَحْـدَكَ لا شَريكَ لَـك ، وَأَنَّ ُ مُحَمّـداً عَبْـدُكَ وَرَسـولُـك. ";
                    

                    break;

                case 10:
                    textBox2.Text = "اللّهُـمَّ عافِـني في بَدَنـي ، اللّهُـمَّ عافِـني في سَمْـعي ، اللّهُـمَّ عافِـني في بَصَـري ، لا إلهَ إلاّ أَنْـتَ. ";
                   
                    break;
                case 11:
                    textBox2.Text = "سُبْحـانَ اللهِ وَبِحَمْـدِهِ عَدَدَ خَلْـقِه ، وَرِضـا نَفْسِـه ، وَزِنَـةَ عَـرْشِـه ، وَمِـدادَ كَلِمـاتِـه.";
                    

                    break;
                case 12:
                    textBox2.Text = "اللّهُـمَّ إِنّـي أَعـوذُ بِكَ مِنَ الْكُـفر ، وَالفَـقْر ، وَأَعـوذُ بِكَ مِنْ عَذابِ القَـبْر ، لا إلهَ إلاّ أَنْـتَ. ";
                 

                    break;
                case 13:
                    textBox2.Text = "اللّهُـمَّ إِنِّـي أسْـأَلُـكَ العَـفْوَ وَالعـافِـيةَ في الدُّنْـيا وَالآخِـرَة ، اللّهُـمَّ إِنِّـي أسْـأَلُـكَ العَـفْوَ وَالعـافِـيةَ في ديني وَدُنْـيايَ وَأهْـلي وَمالـي ، اللّهُـمَّ اسْتُـرْ عـوْراتي وَآمِـنْ رَوْعاتـي ، اللّهُـمَّ احْفَظْـني مِن بَـينِ يَدَيَّ وَمِن خَلْفـي وَعَن يَمـيني وَعَن شِمـالي ، وَمِن فَوْقـي ، وَأَعـوذُ بِعَظَمَـتِكَ أَن أُغْـتالَ مِن تَحْتـي. ";
                  
                    break;
                case 14:
                    textBox2.Text = "يَا حَيُّ يَا قيُّومُ بِرَحْمَتِكَ أسْتَغِيثُ أصْلِحْ لِي شَأنِي كُلَّهُ وَلاَ تَكِلْنِي إلَى نَفْسِي طَـرْفَةَ عَيْنٍ. ";
                     break;
                case 15:
                    textBox2.Text = "أَعـوذُ بِكَلِمـاتِ اللّهِ التّـامّـاتِ مِنْ شَـرِّ ما خَلَـق. ";
                    
                    break;
                case 16:
                    textBox2.Text = "اللَّهُمَّ صَلِّ وَسَلِّمْ وَبَارِكْ على نَبِيِّنَا مُحمَّد. ";
                    
                    break;
                case 17:
                    textBox2.Text = "اللَّهُمَّ إِنَّا نَعُوذُ بِكَ مِنْ أَنْ نُشْرِكَ بِكَ شَيْئًا نَعْلَمُهُ ، وَنَسْتَغْفِرُكَ لِمَا لَا نَعْلَمُهُ. ";
                   
                    break;
                case 18:
                    textBox2.Text = "سُبْحـانَ اللهِ وَبِحَمْـدِهِ. ";

                    break;

                case 19:
                    textBox2.Text = "يَا رَبِّ , لَكَ الْحَمْدُ كَمَا يَنْبَغِي لِجَلَالِ وَجْهِكَ , وَلِعَظِيمِ سُلْطَانِكَ. ";
               
                    break;
                case 20:
                    textBox2.Text = "لَا إلَه إلّا اللهُ وَحْدَهُ لَا شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلِّ شَيْءِ قَدِيرِ. ";
                
                    break;
                case 21:
                    textBox2.Text = "سُبْحـانَ اللهِ وَبِحَمْـدِهِ. ";
                   
                    break;
                case 22:
                    textBox2.Text = "أسْتَغْفِرُ اللهَ وَأتُوبُ إلَيْهِ ";
                   
                    break;

                case 23:
                    textBox2.Text = "اللَّهُمَّ أَنْتَ رَبِّي لا إِلَهَ إِلا أَنْتَ ، عَلَيْكَ تَوَكَّلْتُ ، وَأَنْتَ رَبُّ الْعَرْشِ الْعَظِيمِ , مَا شَاءَ اللَّهُ كَانَ ، وَمَا لَمْ يَشَأْ لَمْ يَكُنْ ، وَلا حَوْلَ وَلا قُوَّةَ إِلا بِاللَّهِ الْعَلِيِّ الْعَظِيمِ , أَعْلَمُ أَنَّ اللَّهَ عَلَى كُلِّ شَيْءٍ قَدِيرٌ ، وَأَنَّ اللَّهَ قَدْ أَحَاطَ بِكُلِّ شَيْءٍ عِلْمًا , اللَّهُمَّ إِنِّي أَعُوذُ بِكَ مِنْ شَرِّ نَفْسِي ، وَمِنْ شَرِّ كُلِّ دَابَّةٍ أَنْتَ آخِذٌ بِنَاصِيَتِهَا ، إِنَّ رَبِّي عَلَى صِرَاطٍ مُسْتَقِيمٍ.";
                  
                    break;
                
                default:
                    break;
            }
           int Minute = DateTime.Now.Minute;
            if (Minute<= 5)
            {
                textBox1.Text = "لَا إلَه إلّا اللهُ وَحْدَهُ لَا شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلِّ شَيْءِ قَدِيرِ";
            }
            else if (Minute <= 10)
            {
                textBox1.Text = "سُبْحـانَ اللهِ وَبِحَمْـدِهِ";
            }
            else if (Minute <= 15)
            {
                textBox1.Text = "سُبْحَانَ اللَّهِ وَالْحَمْدُ لِلَّهِ ";
            }
            else if (Minute <= 20)
            {
                textBox1.Text = "سُبْحَانَ اللهِ العَظِيمِ وَبِحَمْدِهِ ";
            }
            else if (Minute <= 25)
            {
                textBox1.Text = "لا حَوْلَ وَلا قُوَّةَ إِلا بِاللَّهِ";
            }
            else if (Minute <= 30)
            {
                textBox1.Text = "الْلَّهُم صَلِّ وَسَلِم وَبَارِك عَلَى سَيِّدِنَا مُحَمَّد";
            }
            else if (Minute <= 35)
            {
                textBox1.Text = "أسْتَغْفِرُ اللهَ وَأتُوبُ إلَيْهِ";
            }
            else if (Minute <= 40)
            {
                textBox1.Text = "سُبْحَانَ الْلَّهِ، وَالْحَمْدُ لِلَّهِ، وَلَا إِلَهَ إِلَّا الْلَّهُ، وَالْلَّهُ أَكْبَرُ ";
            }
            else if (Minute <= 45)
            {
                textBox1.Text = "سُبْحَانَ اللَّهِ ، وَالْحَمْدُ لِلَّهِ ، وَلا إِلَهَ إِلا اللَّهُ ، وَاللَّهُ أَكْبَرُ ، اللَّهُمَّ اغْفِرْ لِي ، اللَّهُمَّ ارْحَمْنِي ، اللَّهُمَّ ارْزُقْنِ";
            }
            else if (Minute <= 50)
            {
                textBox1.Text = "اللَّهُمَّ صَلِّ عَلَى مُحَمَّدٍ وَعَلَى آلِ مُحَمَّدٍ كَمَا صَلَّيْتَ عَلَى إِبْرَاهِيمَ , وَعَلَى آلِ إِبْرَاهِيمَ إِنَّكَ حَمِيدٌ مَجِيدٌ , اللَّهُمَّ بَارِكْ عَلَى مُحَمَّدٍ وَعَلَى آلِ مُحَمَّدٍ كَمَا بَارَكْتَ عَلَى إِبْرَاهِيمَ وَعَلَى آلِ إِبْرَاهِيمَ إِنَّكَ حَمِيدٌ مَجِيدٌ";
            }
            else if (Minute <= 55)
            {
                textBox1.Text = "سُبْحَانَ اللَّهِ وَبِحَمْدِهِ ، سُبْحَانَ اللَّهِ الْعَظِيمِ ";
            }
            else if (Minute <= 60)
            {
                textBox1.Text = "رَضيـتُ بِاللهِ رَبَّـاً وَبِالإسْلامِ ديـناً وَبِمُحَـمَّدٍ صلى الله عليه وسلم نَبِيّـا";
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void azkar_Click(object sender, EventArgs e)
        {
            i++;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            i=0;    
        }
    }

}

