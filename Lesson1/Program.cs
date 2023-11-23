Console.Clear(); 

// set shape(square)
int xa = 0, ya = 0,
    xb = 0, yb = 60,
    xc = 60, yc = 0,
    xd = 60, yd = 60;

int x = xa, y = ya;
int count = 0;

while (count < 2000) {
    int what = new Random().Next(0, 4);

    // depending on the random number, set the coordinates to the middle of the initial values
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
    if (what == 3) {
        x = (x + xd) / 2;
        y = (y + yd) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count++;
}

Console.SetCursorPosition(0, 30);// set cursor to the end of shape
