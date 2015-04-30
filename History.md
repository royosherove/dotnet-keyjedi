KeyJedi by Roy Osherove
Roy@Osherove.com
www.osherove.com


* parts of the code are taken from:
- http://www.codeproject.com/csharp/GlobalSystemHook.asp
- http://www.c-sharpcorner.com/UploadFile/satisharveti/ActiveApplicationWatcher01252007024921AM/ActiveApplicationWatcher.aspx

Lately the source code has been lost, and recovered thanks to http://www.twitter.com/davidadsit

Version 1.05
--------------
- Added settings in config file: ShowTabs, ShowEnter,ShowPageUpDown
- Added support for Windows Key combos

Version 1.04
--------------
- Added "Mousless Mode": Pressing Ctrl-Shift-alt-F12
    will disable the mouse for the currently active application
	and force you to work with the keyboard only in that specific application.
	Pressing ctrl-shift.alt-f12 again will stop this mode.
	See basicUsage.txt for config setting.

- Added Memo Ability
	- double clicking on a list item will allow annotating it with a short string.
	- later, you can right click on the list, and copy the annoations and shortcuts to the clipboard.

Version 1.03
------------
- Added BasicUsage.txt and History.txt ro release
- Renamed application to "Key Jedi" and KeyJedi.exe
- Added link to blog
- Made opacity scroll smaller
- App now has only  ONE version, with a config file setting to control
	whether it only listens to visual studio shortcuts or all applications.
	for more info see basicusage.txt
	
Version 1.02 
---------------
- Control->Ctrl
- Item list limited to 10 items
- Config file setting: VisualStudioOnly: true: watch only visual studio keyboard. false: watch all applications.

Version 1.01 28-5-07
---------------
 - Added support for standalong F1-12 keys detection
 - Addded configuration file for basic properties: Font, backcolor, forecolor, opacity
 
 
Version 1.00 27-5-07
------------
* Initial Release