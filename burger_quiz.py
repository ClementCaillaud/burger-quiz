# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 18:47:38 2019

@author: Clément
"""

from application import Application

def main():
    print("Bienvenue dans Burger Quiz")    
    app = Application()
    app.display_image("score")
    app.start()

if __name__ == "__main__":
    main()   