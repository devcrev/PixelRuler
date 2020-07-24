# DevCrev Utility: PixelRuler

## Description

This Windows program is useful for measuring the width and height of an area in pixels.
- Window is semi-transparent
- Window is movable
- Window is resizable
    - 0, 0 coordinate is at the top-left corner, i.e., white area
    - Title bar shows the bottom-right corner coordinate, i.e., white area
    - Title bar changes as you resize the window
- Window stays on top of other windows
- Each square is 100 pixels by 100 pixels
    - Blue rule lines and labels are for width
    - Red rule lines and labels are for height
    - Ticks between primary lines are at 25, 50, and 75 pixels

This picture shows the application window on top of a browser window. The black
lines and text are there only for documentation and do not display when running
the program:

![Description](./Description.png?raw=true "Visual Description")

## Build

I built this program using Microsoft Visual Studio Professional 2019
Version 16.6.5.

.NET Target framework is 4.7.2

Open PixelRuler.sln in Visual Studio and build the program as you see fit.
