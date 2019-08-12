# -*- coding: utf-8 -*-
"""
Created on Mon Aug 12 18:33:31 2019

@author: Clément
"""

class Team:
    def __init__(self, name):
        self.name = name
        self.members = []
        self.score = 0
    
    def add_member(self, member):
        self.members.push(member)
    
    def get_members(self):
        return self.members
    
    def get_name(self):
        return self.name
    
    def add_score(self, value):
        self.score += value
    
    def get_score(self):
        return self.score