# DoorRestartSystem

## Information
This plugin locks all doors after a random set period of time and unlocks them after a given time.
You can customize almost everything so that the plugins fits to your preferences.

## Requirements
- EXILED Version 8.8.0

## Installation Guide
- Download the .dll file and place it in your EXILED/Plugins folder
- The plugin will automatically works, however, if you want to change settings, you have to edit the "PORT-config.yaml"-file.

## Default Config
```
# Whether or not the plugin is enabled
is_enabled: true
# Whether or not debug messages will be shown (not implented yet)
debug: false
# When the first cycle can start after the round started (in seconds, You can set this from 0 to infinity)
first_cycle: 60
# First intervall when the next cycle can occur (in seconds, You can set this from 0 to infinity)
first_interval: 180
# Second intervall when the next cycle can occur (in seconds, You can set this from 0 to infinity)
last_interval: 300
# How long the lockdown should last (in seconds, You can this from 0 to infinity)
lockdown_duration: 50
# How many times a cycle can occur in one round (0 = infinite)
cycles_count: 1
# The cassie message that should be played when the lockdown starts
cassie_message_start: 'pitch_0.3 .g4 .g4 pitch_1.00 Attention all Personnel . Door malfunction detected . Lockdown activated'
# The cassie message that should be played when the lockdowns ends
cassie_message_end: 'pitch_0.35 .g5 pitch_1.00 Lockdown deactivated . Door controls back online'
```

## Permission
-/-
