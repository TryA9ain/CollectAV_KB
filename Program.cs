using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CollectAV_KB
{
    class Program
    {
        /// <summary>
        /// 定义收集杀软的方法 avCollect
        /// </summary>
        /// <returns></returns>
        static void avCollect()
        {
            //创建一个杀软列表的集合 av_list
            Dictionary<string, string> av_list = new Dictionary<string, string>();
            av_list.Add("360tray.exe", "360安全卫士-实时保护");
            av_list.Add("360safe.exe", "360安全卫士-主程序");
            av_list.Add("ZhuDongFangYu.exe", "360安全卫士-主动防御");
            av_list.Add("360sd.exe", "360杀毒");
            av_list.Add("a2guard.exe", "a-squared杀毒");
            av_list.Add("ad-watch.exe", "Lavasoft杀毒");
            av_list.Add("cleaner8.exe", "The Cleaner杀毒");
            av_list.Add("vba32lder.exe", "vb32杀毒");
            av_list.Add("MongoosaGUI.exe", "Mongoosa杀毒");
            av_list.Add("CorantiControlCenter32.exe", "Coranti2012杀毒");
            av_list.Add("F-PROT.exe", "F-Prot AntiVirus");
            av_list.Add("CMCTrayIcon.exe", "CMC杀毒");
            av_list.Add("K7TSecurity.exe", "K7杀毒");
            av_list.Add("UnThreat.exe", "UnThreat杀毒");
            av_list.Add("CKSoftShiedAntivirus4.exe", "Shield Antivirus杀毒");
            av_list.Add("AVWatchService.exe", "VIRUSfighter杀毒");
            av_list.Add("ArcaTasksService.exe", "ArcaVir杀毒");
            av_list.Add("iptray.exe", "Immunet杀毒");
            av_list.Add("PSafeSysTray.exe", "PSafe杀毒");
            av_list.Add("nspupsvc.exe", "nProtect杀毒");
            av_list.Add("SpywareTerminatorShield.exe", "SpywareTerminator杀毒");
            av_list.Add("BKavService.exe", "Bkav杀毒");
            av_list.Add("MsMpEng.exe", "Microsoft Security Essentials");
            av_list.Add("SBAMSvc.exe", "VIPRE");
            av_list.Add("ccSvcHst.exe", "Norton杀毒");
            av_list.Add("f-secure.exe", "冰岛");
            av_list.Add("avp.exe", "Kaspersky");
            av_list.Add("KvMonXP.exe", "江民杀毒");
            av_list.Add("RavMonD.exe", "瑞星杀毒");
            av_list.Add("Mcshield.exe", "Mcafee");
            av_list.Add("Tbmon.exe", "Mcafee");
            av_list.Add("Frameworkservice.exe", "Mcafee");
            av_list.Add("egui.exe", "ESET NOD32");
            av_list.Add("ekrn.exe", "ESET NOD32");
            av_list.Add("eguiProxy.exe", "ESET NOD32");
            av_list.Add("kxetray.exe", "金山毒霸");
            av_list.Add("knsdtray.exe", "可牛杀毒");
            av_list.Add("TMBMSRV.exe", "趋势杀毒");
            av_list.Add("avcenter.exe", "Avira(小红伞)");
            av_list.Add("avguard.exe", "Avira(小红伞)");
            av_list.Add("avgnt.exe", "Avira(小红伞)");
            av_list.Add("sched.exe", "Avira(小红伞)");
            av_list.Add("ashDisp.exe", "Avast网络安全");
            av_list.Add("rtvscan.exe", "诺顿杀毒");
            av_list.Add("ccapp.exe", "Symantec Norton");
            av_list.Add("NPFMntor.exe", "Norton杀毒软件相关进程");
            av_list.Add("ccSetMgr.exe", "赛门铁克");
            av_list.Add("ccRegVfy.exe", "Norton杀毒软件自身完整性检查程序");
            av_list.Add("vptray.exe", "Norton病毒防火墙-盾牌图标程序");
            av_list.Add("ksafe.exe", "金山卫士");
            av_list.Add("QQPCRTP.exe", "QQ电脑管家");
            av_list.Add("Miner.exe", "流量矿石");
            av_list.Add("AYAgent.exe", "韩国胶囊");
            av_list.Add("patray.exe", "安博士");
            av_list.Add("V3Svc.exe", "安博士V3");
            av_list.Add("avgwdsvc.exe", "AVG杀毒");
            av_list.Add("QUHLPSVC.exe", "QUICK HEAL杀毒");
            av_list.Add("mssecess.exe", "微软杀毒");
            av_list.Add("SavProgress.exe", "Sophos杀毒");
            av_list.Add("fsavgui.exe", "F-Secure杀毒");
            av_list.Add("vsserv.exe", "比特梵德");
            av_list.Add("remupd.exe", "熊猫卫士");
            av_list.Add("FortiTray.exe", "飞塔");
            av_list.Add("safedog.exe", "安全狗");
            av_list.Add("parmor.exe", "木马克星");
            av_list.Add("Iparmor.exe.exe", "木马克星");
            av_list.Add("beikesan.exe", "贝壳云安全");
            av_list.Add("KSWebShield.exe", "金山网盾");
            av_list.Add("TrojanHunter.exe", "木马猎手");
            av_list.Add("GG.exe", "巨盾网游安全盾");
            av_list.Add("adam.exe", "绿鹰安全精灵");
            av_list.Add("AST.exe", "超级巡警");
            av_list.Add("ananwidget.exe", "墨者安全专家");
            av_list.Add("AVK.exe", "GData");
            av_list.Add("avg.exe", "AVG Anti-Virus");
            av_list.Add("spidernt.exe", "Dr.web");
            av_list.Add("avgaurd.exe", "Avira Antivir");
            av_list.Add("vsmon.exe", "ZoneAlarm");
            av_list.Add("cpf.exe", "Comodo");
            av_list.Add("outpost.exe", "Outpost Firewall");
            av_list.Add("rfwmain.exe", "瑞星防火墙");
            av_list.Add("kpfwtray.exe", "金山网镖");
            av_list.Add("FYFireWall.exe", "风云防火墙");
            av_list.Add("MPMon.exe", "微点主动防御");
            av_list.Add("pfw.exe", "天网防火墙");
            av_list.Add("1433.exe", "在扫1433");
            av_list.Add("DUB.exe", "在爆破");
            av_list.Add("ServUDaemon.exe", "发现S-U");
            av_list.Add("BaiduSdSvc.exe", "百度杀毒-服务进程");
            av_list.Add("BaiduSdTray.exe", "百度杀毒-托盘进程");
            av_list.Add("BaiduSd.exe", "百度杀毒-主程序");
            av_list.Add("SafeDogGuardCenter.exe", "安全狗");
            av_list.Add("safedogupdatecenter.exe", "安全狗");
            av_list.Add("safedogguardcenter.exe", "安全狗");
            av_list.Add("SafeDogSiteIIS.exe", "安全狗");
            av_list.Add("SafeDogTray.exe", "安全狗");
            av_list.Add("SafeDogServerUI.exe", "安全狗");
            av_list.Add("D_Safe_Manage.exe", "D盾");
            av_list.Add("d_manage.exe", "D盾");
            av_list.Add("yunsuo_agent_service.exe", "云锁");
            av_list.Add("yunsuo_agent_daemon.exe", "云锁");
            av_list.Add("HwsPanel.exe", "护卫神");
            av_list.Add("hws_ui.exe", "护卫神");
            av_list.Add("hws.exe", "护卫神");
            av_list.Add("hwsd.exe", "护卫神");
            av_list.Add("hipstray.exe", "火绒");
            av_list.Add("wsctrl.exe", "火绒");
            av_list.Add("usysdiag.exe", "火绒");
            av_list.Add("WEBSCANX.EXE", "网络病毒克星");
            av_list.Add("SPHINX.EXE", "SPHINX防火墙");
            av_list.Add("bddownloader.exe", "百度卫士");
            av_list.Add("baiduansvx.exe", "百度卫士-主进程");
            av_list.Add("AvastUI.exe", "Avast!5主程序");

            Cmd cmd = new Cmd();
            string avRes = cmd.RunCmd("tasklist /svc");//掉用 Cmd类里的 RunCmd 方法来执行“tasklist /svc”命令

            foreach (var eachRes in av_list)
            {
                if (avRes.IndexOf(eachRes.Key) != -1)
                {

                    Console.WriteLine("存在的杀软信息如下：" + eachRes.Key + ":" + eachRes.Value);
                }
            }
        }
        /// <summary>
        /// 创建异步
        /// </summary>
        /// <returns></returns>
        static async Task methodAsync()
        {
            var avCollectTask = Task.Run(() => avCollect());

            string nameEmpty = ""; //定义一个空的 nameEmpty 用来在下面接收执行RunCmd的返回值
            var osCmdTask = Task.Run(() =>
            {
                Cmd osCmd = new Cmd();
                nameEmpty = osCmd.RunCmd("systeminfo | findstr \"名称\"");
            });

            string kbEmpty = "";
            var kbCmdTask = Task.Run(() =>
            {
                Cmd cmdKB = new Cmd();
                kbEmpty = cmdKB.RunCmd("systeminfo | findstr \"KB\"");
            });

            var taskList = new List<Task> { avCollectTask, osCmdTask, kbCmdTask }; //任务列表

            while (taskList.Count > 0)
            {
                //使用 WhenAny 来获取任务是否完成，哪个任务完成，就会得到其运行完毕的输出结果，只有当前这个任务完成了，才会向下执行，然后把完成的任务从 taskList 列表中删除；反复循环，直至taskList列表中为空，结束while循环
                //taskList 列表中的任务哪个任务先完成，就会得到其输出的结果；不需要等待taskList列表中的所有任务全部完成再一起输出结果
                Task finishTask = await Task.WhenAny(taskList);
                taskList.Remove(finishTask);
            }

            //定义Win2019的 cve列表
            List<string> win2019_CVE = new List<string>
            {
                "CVE-2020-0787", "CVE-2019-0803"
            };
            //定义Win2016的 cve列表
            List<string> win2016_CVE = new List<string>
            {
                "CVE-2020-0787", "CVE-2019-1458", "CVE-2019-0803", "CVE-2018-8639", "CVE-2018-8440"
            };

            //定义Win2012的 cve列表
            List<string> win2012_CVE = new List<string>
            {
                "CVE-2020-0787", "CVE-2019-1458", "CVE-2019-0803", "CVE-2018-8639", "CVE-2018-8440", "CVE-2017-8464", "CVE-2017-0213"
            };
            //定义Win10的 cve漏洞列表
            List<string> win10_CVE = new List<string>
            {
                "CVE-2020-0787", "CVE-2019-1458", "CVE-2019-0803", "CVE-2018-8639", "CVE-2018-8440", "CVE-2017-8464", "CVE-2017-0213"
            };

            //定义win2008 的cve漏洞列表
            List<string> win2008_CVE = new List<string>
            {
                "CVE-2020-0787", "CVE-2019-1458", "CVE-2019-0803", "CVE-2018-8639", "CVE-2018-8440", "CVE-2017-8464", "CVE-2017-0213"
            };

            Regex osRegex = new Regex(@"Windows.*\d ");
            Regex serverOsRegex = new Regex(@"Windows.*\d{4} ");
            MatchCollection osCollection = osRegex.Matches(nameEmpty);
            MatchCollection serverCollection = serverOsRegex.Matches(nameEmpty);
            string osRes = "";
            string serverOsRes = "";

            foreach (var osEach in osCollection)
            {
                osRes = osEach.ToString().Replace(" ", "");
            }

            foreach (var serverEach in serverCollection)
            {
                serverOsRes = serverEach.ToString().Replace(" ", "");
            }

            Console.WriteLine("可优先尝试 Potato家族 提权或 基于服务提权");

            if (serverOsRes == "WindowsServer2019")
            {
                Console.WriteLine("Windows2019可能存在的CVE漏洞： " + string.Join(", ", win2019_CVE));
            }
            else if (serverOsRes == "WindowsServer2016")
            {
                Console.WriteLine("Windows2016可能存在的CVE漏洞： " + string.Join(", ", win2016_CVE));
            }
            else if (serverOsRes == "WindowsServer2012")
            {
                Console.WriteLine("Windows2012可能存在的CVE漏洞： " + string.Join(", ", win2012_CVE));
            }
            else if (osRes == "Windows10")
            {
                Console.WriteLine("Windows10可能存在的CVE漏洞： " + string.Join(", ", win10_CVE));
            }

            else if (serverOsRes == "WindowsServer2008")
            {
                Console.WriteLine("Windows2008可能存在的CVE漏洞： " + string.Join(", ", win2008_CVE));
            }

            //win2016 MS漏洞列表
            Dictionary<string, string> win2016_KBList = new Dictionary<string, string>();
            win2016_KBList.Add("KB3199135", "MS16-135");

            //wind2012 MS漏洞列表
            Dictionary<string, string> win2012_KBList = new Dictionary<string, string>();
            win2012_KBList.Add("KB3164038", "MS16-075");
            win2012_KBList.Add("KB3143145", "MS16-034");
            win2012_KBList.Add("KB3143141", "MS16-032");
            win2012_KBList.Add("KB3089656", "MS15-097");
            win2012_KBList.Add("KB3067505", "MS15-076");
            win2012_KBList.Add("KB3077657", "MS15-077");
            win2012_KBList.Add("KB3057839", "MS15-061");
            win2012_KBList.Add("KB3057191", "MS15-051");
            win2012_KBList.Add("KB3031432", "MS15-015");
            win2012_KBList.Add("KB3023266", "MS15-001");
            win2012_KBList.Add("KB3011780", "MS14-068");
            win2012_KBList.Add("KB3000061", "MS14-058");
            win2012_KBList.Add("KB2992611", "MS14-066");
            win2012_KBList.Add("KB2975684", "MS14-040");
            win2012_KBList.Add("KB2840221", "MS13-046");
            win2012_KBList.Add("KB2778930", "MS13-005");
            win2012_KBList.Add("KB2972621", "MS12-042");

            //win10 MS漏洞列表
            Dictionary<string, string> win10_KBList = new Dictionary<string, string>();
            win10_KBList.Add("KB3143145", "MS16-034");
            win10_KBList.Add("KB3143141", "MS16-032");

            //windows2008 MS漏洞列表
            Dictionary<string, string> win2008_KBList = new Dictionary<string, string>();
            win2008_KBList.Add("KB4013081", "MS17-017");
            win2008_KBList.Add("KB4013389", "MS17-010");
            win2008_KBList.Add("KB3164038", "MS16-075");
            win2008_KBList.Add("KB3143145", "MS16-034");
            win2008_KBList.Add("KB3143141", "MS16-032");
            win2008_KBList.Add("KB3136041", "MS16-016");
            win2008_KBList.Add("KB3134228", "MS16-014");
            win2008_KBList.Add("KB3067505", "MS15-076");
            win2008_KBList.Add("KB3077657", "MS15-077");
            win2008_KBList.Add("KB3057839", "MS15-061");
            win2008_KBList.Add("KB3057191", "MS15-051");
            win2008_KBList.Add("KB3036220", "MS15-010");
            win2008_KBList.Add("KB3023266", "MS15-001");
            win2008_KBList.Add("KB3011780", "MS14-068");
            win2008_KBList.Add("KB3000061", "MS14-058");
            win2008_KBList.Add("KB2975684", "MS14-040");
            win2008_KBList.Add("KB2850851", "MS13-053");
            win2008_KBList.Add("KB2840221", "MS13-046");
            win2008_KBList.Add("KB2778930", "MS13-005");
            win2008_KBList.Add("KB2972621", "MS12-042");
            win2008_KBList.Add("KB2671387", "MS12-020");
            win2008_KBList.Add("KB2503665", "MS11-046");
            win2008_KBList.Add("KB2393802", "MS11-011");
            win2008_KBList.Add("KB2305420", "MS10-092");
            win2008_KBList.Add("KB982799", "MS10-059");
            win2008_KBList.Add("KB977165", "MS10-015");
            win2008_KBList.Add("KB975517", "MS09-050");
            win2008_KBList.Add("KB959454", "MS09-012");
            win2008_KBList.Add("KB958644", "MS08-067");
            win2008_KBList.Add("KB941693", "MS08-025");

            //正则提取KB信息
            var targetKB = new List<string>();
            Regex re = new Regex(@"([KB])+(\d{4}\d*)");
            MatchCollection kbCollection = re.Matches(kbEmpty);

            foreach (var eachRes in kbCollection)
            {
                targetKB.Add(eachRes.ToString());
            }

            var kbEmptyList = new List<string>();
            if (serverOsRes == "WindowsServer2016")
            {
                foreach (string win2016Key in win2016_KBList.Keys)
                {
                    if (!targetKB.Contains(win2016Key))
                    {
                        kbEmptyList.Add(win2016_KBList[win2016Key]);
                    }
                }
                Console.WriteLine("Win2016可能存在的MS漏洞： " + string.Join(", ", kbEmptyList));
            }
            else if (osRes == "Windows10")
            {
                foreach (string eachKey in win10_KBList.Keys)
                {
                    if (!targetKB.Contains(eachKey))
                    {
                        kbEmptyList.Add(win10_KBList[eachKey]);
                    }

                }

                Console.WriteLine("Win10可能存在的MS漏洞： " + string.Join(", ", kbEmptyList));
            }
            else if (serverOsRes == "WindowsServer2012")
            {
                foreach (string eachKey in win2012_KBList.Keys)
                {
                    if (!targetKB.Contains(eachKey))
                    {
                        kbEmptyList.Add(win2012_KBList[eachKey]);
                    }
                }

                Console.WriteLine("Win2012可能存在的MS漏洞： " + string.Join(", ", kbEmptyList));
            }
            else if (serverOsRes == "WindowsServer2008")
            {
                foreach (string eachKey in win2008_KBList.Keys)
                {
                    if (!targetKB.Contains(eachKey))
                    {
                        kbEmptyList.Add(win2008_KBList[eachKey]);
                    }

                }

                Console.WriteLine("Win2008可能存在的MS漏洞： " + string.Join(", ", kbEmptyList));
            }
        }
        static async Task Main(string[] args)
        {
            await methodAsync();
        }
    }
}
