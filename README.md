# TR Transfer/Control Application
Minimal Win App for to remotely control your C64/128 via TeensyROM and a USB or Ethernet connection.

![Window Capture](TR_Transfer-Control.png)

### Platform Support
* Windows:
  * Run "C64Transfer vX.Y.exe"
* MacOS:
  * brew install wine-stable
  * wine C64Transfer\ vX.Y.exe
* Linux: (Not tested)
  * wine in Linux with package manager like apt-get or yum

### Ethernet Setup
* TeensyROM requires FW version 0.7 (or later)
* Connect ethernet cable to the TR and power up C64/128
* Go into the setup menu (F8) and turn on the TCP Listenner (i), then reboot (j) or power cycle
  * The TR will defult to DHCP IP address acquisition.  If static is prefered, or to change other network settings, use the built-in CCGMS and AT commands to modify.  See details in [this document](https://github.com/SensoriumEmbedded/TeensyROM/blob/main/docs/Ethernet_Usage.md).
* There are two ways to determine the local IP address (if DHCP):
  * From the settings menu, do the immediate Synch time via Ethernet (k).  It will pause with the local IP displayed.
  * From CCGMS (hot key '3') type the 'ATC' command to show it there.
* Enter the IP address into the TRWin App, you are now ready to remote control your C64 via Ethernet

### USB Setup
* Connect a USB cable from your PC to the USB-micro port on the TeensyROM.
* Refresh the Serial Port list in the TRWin App (...) then select the com associated COM port.
* You are now ready to remote control your C64 via USB


I use it mostly for testing and interface development. For a vastly improved UI experience, use [the TeensyROM-UI](https://github.com/MetalHexx/TeensyROM-UI) :)

