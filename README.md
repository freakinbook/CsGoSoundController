# CsGoSoundController

I was always manually setting my windows volume to 100 % before playing CS:GO so I could hear better. 

But then I had to manually set it back to 20 % when I was done playing.

This service took care of it.

It's checking whether there is a csgo process using the observer pattern. When the process starts, it sets volume to 100 and when it finishes it changes it to 20.

<hr>

Перед игрой в CS:GO я всегда вручную изменял громкость на 100 %, чтобы лучше слышать звуки в игре.

Но после игры мне приходилось изменять громкость обратно на свои стандартные 20 %.

Поэтому я сделал эту службу windows, которая бы об этом заботилась.

Она проверяет, запущен ли процесс CS:GO используя паттерн Наблюдатель. Когда процесс появляется, громкость повышается до 100, когда завершается, громкость возвращается к 20.
