# xamarin form web app

1. xamarin.Resources.nodejs 目录下执行命令： npm run build
1. 生成 xamarin.Resources
1. 生成 xamarin 项目
1. 真机调试
1. webview 调试：chrome://inspect/#devices

## xamarin 项目

1. 使用 web view 控件呈现界面
1. 使用 EmbedIO 作为 APP 内运行的 Web Server
1. 使用 Resources 项目中的 nodejs/dist 作为嵌入式资源

## xamarin.Resources 项目

1. nodejs 目录作为前端项目根目录
1. 采用 vite+ vue 3 + vue router + pinia + vant

## xamarin.Android 项目

1. 启动画面通过 MainActivity 的 Theme 设置，启动后在 MainActivity 的 OnCreate 方法中重置 Theme 的方式实现
1. AndroidManifest.xml 的 application 节点 添加了 android:usesCleartextTraffic="true" 属性
## xamarin.iOS 项目