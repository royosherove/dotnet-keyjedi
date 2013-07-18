This project is licensed under the Apache 2 License.

Using Keyboard Jedi - 1 minute guide
By Roy Osherove (Roy at Osherove.com)
Blog: www.osherove.com
---------------------
You may use and distribute this program freely as long as you do not change it in any way,
including credits and associated text files.
----------------------------------------------------

1. Double click the program exe file
2. adjust the opacity by using the slider at the bottom
3. as you click keyboard shortcuts, the last shortcut will appear at the top.

***Mousless Mode[optional]***
4. Key Jedi can help you overcome your fear of the keyboard
	by disabling the mouse for the currently active application.
	Pressing the special "Mousless" global key (default is ctrl-shift-alt-F12)
	will make sure the mouse can never leave the confines of Key Jedi window
	as long as the application which was selected when the key was pressed is still active.
	For example:
	- Open Visual Studio when Key Jedi is running. Make vs the active app.
	- Press Ctrl-shift-alt-f12
	- Key jedi will tell you you are in mousless mode for vs.
	- your mouse will be "held prisoner" in the bounds of Key Jedi.
	- you will only be able to use your keyboard to operate VS. Use this mode to force yourself to learn keyboard shortcuts instead of using the mouse.
	- If you alt-tab to a different application your mouse will be free.
	- if you alt-tab back to VS, your mouse will lock again.
	- press ctrl-alt-shift-f12 again to regain mouse contorl.

Configuration settings (*.exe.config):
-------------------------------------
- VisualStudioOnly
-----------------
	- True: Shortcuts will only appear in KJ when Visual Studio is the active application.
	- False: Every shortcuts in EVERY application will appear in KJ.

- MouselessModeKey (string)
-------------------
	- This decides what global key will activate "Mouseless mode"
	for the active application.
	The default is Shift+Alt+Ctrl+F12
	
	- Set this to a string with the following parts:
	[Special key] + [other key]...
	example:
	Shift+Ctrl+K
	Alt+Shift+Ctrl+F5
	
- Opacity (0.1-1.0)
-------------------
	- Control the initial opacity of the application
- BackColor
-------------------
	- Set to any System.Color such as "Blue", "White", "Window" etc..
		will be the background of the list.
		
- ForeColor
---------------
	- Set the color of the FIRST item in the list.
	- all other items are colored to slowly "fade".
- ListFont
-----------
	- Set the font that will appear in the list.
