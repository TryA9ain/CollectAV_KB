using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectAV_KB
{
    public class Cmd
    {

        /// <summary>
        /// 实例化 process
        /// </summary>
        Process process = new Process();


        /// <summary>
        /// 定义执行cmd命令的方法 RunCmd
        /// </summary>
        /// <param name="cmd">要执行的cmd命令</param>
        /// <returns></returns>
        public string RunCmd(string cmd)
        {
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.StandardInput.WriteLine(cmd);
            process.StandardInput.WriteLine("exit");
            string backEnd = process.StandardOutput.ReadToEnd();
            process.Close();
            return backEnd;
        }
    }


}