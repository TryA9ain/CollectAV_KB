# CollectAV_KB
## 辅助提权(.NET4.5+)
使用异步方法快速收集目标所运行的杀软和补丁信息
使用时直接CS内存加载即可，无需文件落地

杀软收集参考了 https://github.com/uknowsec/SharpAVKB
添加了异步来加快收集速度，修改针对不同的Windows版本可利用的漏洞

漏洞列表根据 https://github.com/SecWiki/windows-kernel-exploits 
来添加的，包含Win2019，Win2016，Win202，Win2008，Win10

## 使用方法
可直接拉取源码使用vs2019默认环境编译，我也打包好了一份，直接下载即可
推荐使用CS内存加载，上传到目标在执行也可


