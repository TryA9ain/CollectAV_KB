# CollectAV_KB
## 辅助提权(.NET4.5+)
2012以上自带`.NET4.5`,2008可选择静默安装

## 2008静默安装`.NET4.5`
如果目标上有杀软的话，调用PS下载会被拦截

这里推荐 https://github.com/bitsadmin/nopowershell 可绕过360、火绒

*注意需要去cna中修改一下 `NoPowerShell.exe` 的路径，否则会报错，路径信息根据自己的路径修改即可
```
修改前
![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-30-59.jpg)
修改后
![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-31-31.jpg)
```
### 使用异步方法快速收集目标所运行的杀软和补丁信息
要求目标的.NET版本为`.NET4.5`以上(因为用的异步方法只支持`.NET4.5+`，懒+嫌麻烦+菜=不改 (摊牌了，主要就是菜))

杀软收集参考了 https://github.com/uknowsec/SharpAVKB
添加了异步来加快收集速度，修改针对不同的Windows版本可利用的漏洞

漏洞列表根据 https://github.com/SecWiki/windows-kernel-exploits 
来添加的，包含Win2019，Win2016，Win202，Win2008，Win10

MS漏洞判断根据MS漏洞对应的补丁号来判断

CVE漏洞判断根据所影响的版本来判断
## 使用方法
可直接拉取源码使用vs2019默认环境编译，我也打包好了一份，直接下载即可
推荐使用CS内存加载，无需文件落地，上传到目标在执行也可

![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_22-56-16.jpg)

如果目标没有杀软在运行，则直接输出漏洞和补丁信息
![images](https://github.com/TryA9ain/CollectAV_KB/blob/master/images/Snipaste_2020-09-27_23-21-11.jpg)
