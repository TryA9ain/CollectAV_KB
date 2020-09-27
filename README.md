# CollectAV_KB
## 辅助提权(.NET4.5+)
2012以上自带`.NET4.5`,2008可选择静默安装

下载地址：

https://download.microsoft.com/download/E/2/1/E21644B5-2DF2-47C2-91BD-63C560427900/NDP452-KB2901907-x86-x64-AllOS-ENU.exe

### 使用异步快速收集目标所运行的杀软和补丁信息
要求目标的.NET版本为`.NET4.5`以上(因为用的异步方法只支持`.NET4.5+`，懒+嫌麻烦+菜=不改 (摊牌了，主要就是菜))

杀软收集参考了 https://github.com/uknowsec/SharpAVKB

添加了异步来加快收集速度；修改针对不同的Windows版本可利用的漏洞

漏洞列表根据 https://github.com/SecWiki/windows-kernel-exploits 

来添加的，包含Win2019，Win2016，Win2012，Win2008，Win10

MS漏洞判断根据MS漏洞对应的补丁号来判断

CVE漏洞判断根据所影响的版本来判断
## 使用方法
可直接拉取源码使用vs2019默认环境编译；或者直接下载已打包好的二进制文件即可

推荐使用CS内存加载，无需文件落地；如要上传目标再执行也可

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_22-56-16.jpg)

如果目标没有杀软在运行，则直接输出漏洞和补丁信息

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-21-11.jpg)

## 判断目标的.net版本
使用 https://github.com/jmalarcon/DotNetVersions
CS内存加载

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-53-19.jpg)
## 2008静默安装`.NET4.5`
如果目标上有杀软的话，调用PS下载会被拦截

这里推荐 https://github.com/bitsadmin/nopowershell 可绕过360、火绒

*注意需要去cna中修改一下 `NoPowerShell.exe` 的路径，否则会报错，路径信息根据自己的路径修改即可

修改前

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-30-59.jpg)

修改后

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-31-31.jpg)

测试环境为360+火绒

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-37-49.jpg)

使用NoPowerShell来下载

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-46-04.jpg)

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-42-10.jpg)

下载完毕使用`/Q /NORESTART /lcid 1033` 来静默安装

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-43-02.jpg)


## 参考链接
https://github.com/SecWiki/windows-kernel-exploits

https://github.com/uknowsec/SharpAVKB

https://github.com/AonCyberLabs/Windows-Exploit-Suggester

https://github.com/tengzhangchao/microsoftSpider
## 问题建议
各位大佬们如有问题或建议，提交即可
## 如果对您有用的话，请Star哦~~~~
