# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 18:47:38 2019

@author: Clément
"""

from SceneLoader import SceneLoader

def main():
    print("Bienvenue dans Burger Quiz")
    sceneLoader = SceneLoader()
    sceneLoader.load_scene("accueil")

if __name__ == "__main__":
    main()   