'''
Created on 2023年7月20日

@author: MaFar
'''
import process

if __name__ == '__main__':
    score = input()
    print(process.data1[process.data1["分数段"] == score].index)
    pass