AudioSwitcher
=============

A Windows systray utility for quickly changing the default audio device.

Disclaimer: Windows actually doesn't expose an API to change the default audio device, so this utility is based on completely undocumented functionality. As such, you're on your own. Also, I've only seen this work on Windows 7 and 8. 

The utility is essentially a wrapper around https://github.com/DanStevens/AudioEndPointController, which in turn is based on Dave Amenta's excellent work (http://www.daveamenta.com/2011-05/programmatically-or-command-line-change-the-default-sound-playback-device-in-windows-7/). Also inspired (and very much helped out) from http://spikex.net/2011/05/programmatically-changing-the-default-audio-playback-device-on-windows-vista-windows-7/.

![AudioSwitcher](https://raw.githubusercontent.com/marcjoha/AudioSwitcher/screenshots/audioswitcher.png "AudioSwitcher")

How To Use
=
1. Right-click on tray icon to setup.
2. Choose output audio devices which you wanted to switch between.
3. When you want to change output audio device just make mouse left-click on icon in tray.
