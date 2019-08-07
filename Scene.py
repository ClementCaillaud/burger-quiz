# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 19:15:47 2019

@author: Clément
"""

class Scene:
    
    def __init__(self, name, path):
        self.name = name
        self.path = path
    
    def get_nom(self):
        return self.name
    
    def get_path(self):
        return self.path