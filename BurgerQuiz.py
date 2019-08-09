# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 18:47:38 2019

@author: Clément
"""

from Interface import Interface

def main():
    print("Bienvenue dans Burger Quiz")  
    interface = Interface()
    interface.display_image("accueil")
    interface.start()

if __name__ == "__main__":
    main()   