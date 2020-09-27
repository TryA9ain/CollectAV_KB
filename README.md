# CollectAV_KB
## 辅助提权(.NET4.5+)
使用异步方法快速收集目标所运行的杀软和补丁信息
使用时直接CS内存加载即可，无需文件落地

杀软收集参考了 https://github.com/uknowsec/SharpAVKB
添加了异步来加快收集速度，增加准确性，针对不同的Windows版本所对应的漏洞
漏洞列表根据 https://github.com/SecWiki/windows-kernel-exploits 
来添加的，包含Win2019，Win2016，Win202，Win2008，Win10


