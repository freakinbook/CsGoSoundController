# CsGoSoundController

I was always manually setting my windows volume to 100 % before playing CS:GO so I could hear better. 

But then I had to manually set it back to 20 % when I was done playing.

This service took care of it.

It's checking whether there is a csgo process using the observer pattern. When the process starts, it sets volume to 100 and when it finishes it changes it to 20.
