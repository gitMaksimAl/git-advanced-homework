﻿Console.Clear();
int xa = 0, ya = 0,
    xb = 0, yb = 30,
    xc = 60, yc = 30;

int x = xa, y = ya;
int count = 0;

while (count < 2000) {
    int what = new Random().Next(0, 3);
    if (what == 0) {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1) {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2) {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count++;
}
Console.SetCursorPosition(0, 30);
