# https://developer.rhino3d.com/guides/yak/pushing-a-package-to-the-server/

build:
	cd Out/Release/ && \
	"C:\Program Files\Rhino 7\System\Yak.exe" build --platform win && \
	mv fixwindowstoolbar-1.0.0-rh6_35-win.yak fixwindowstoolbar-1.0.0-any-win.yak

init:
	cd Out/Release/ && \
	"C:\Program Files\Rhino 7\System\Yak.exe" spec

push:
	cd Out/Release/ && \
	"C:\Program Files\Rhino 7\System\Yak.exe" push fixwindowstoolbar-1.0.0-any-win.yak

test:
	"C:\Program Files\Rhino 7\System\Yak.exe" search --all fix