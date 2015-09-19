lightsensor
-----------

## description

This software provide ambient light sensor value via WinRT API.

## usage
munin-node.ini
```ini
[Plugins]
External=1

[ExternalPlugin]
Plugin01=C:\path\to\lightsensor.exe
```

## reference

* munin
  http://munin-monitoring.org/
* munin-node-win32  
  https://github.com/munin-monitoring/munin-node-win32
