# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 19:15:47 2019

@author: Clément
"""

class Scene:
    
    def __init__(self, name, image):
        self.name = name
        self.image = image
    
    def get_nom(self):
        return self.name
    
    def get_image(self):
        return self.image
