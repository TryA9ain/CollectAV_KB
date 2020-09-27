# CollectAV_KB
## 辅助提权(.NET4.5+)
### 使用异步方法快速收集目标所运行的杀软和补丁信息
要求目标的.NET版本为.NET4.5以上(因为用的异步方法只支持.net4.5+，懒+嫌麻烦+菜=不改)

杀软收集参考了 https://github.com/uknowsec/SharpAVKB
添加了异步来加快收集速度，修改针对不同的Windows版本可利用的漏洞

漏洞列表根据 https://github.com/SecWiki/windows-kernel-exploits 
来添加的，包含Win2019，Win2016，Win202，Win2008，Win10

MS漏洞判断根据MS漏洞对应的补丁号来判断

CVE漏洞判断根据所影响的版本来判断
## 使用方法
可直接拉取源码使用vs2019默认环境编译，我也打包好了一份，直接下载即可
推荐使用CS内存加载，无需文件落地，上传到目标在执行也可


