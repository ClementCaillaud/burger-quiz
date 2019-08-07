# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 19:07:56 2019

@author: Clément
"""

from Scene import Scene

class SceneLoader:
    
    def __init__(self):
        self.scenesList = [
            Scene("accueil", ""),
            Scene("nuggets", ""),
            Scene("sel ou poivre", ""),
            Scene("menus", ""),
            Scene("addition", ""),
            Scene("burger de la mort", "")]
    
    def load_scene(self, name):
        print("Charger la scène {}" . format(name))
        for i, scene in enumerate(self.scenesList):
            if scene.get_nom() == name:
                print("Affichage de la scène {}" . format(scene.get_nom()))
                return
        print("Aucune scène ne correspond")