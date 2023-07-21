'''
Created on 2023年7月20日

@author: MaFar
'''
import process
import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings
import os

file_path = os.path.realpath(__file__)
py_path = os.path.dirname(os.path.abspath(file_path))
Gaokao_path = os.path.dirname(os.path.dirname(py_path))
warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False
data1 = pd.read_csv(f"{Gaokao_path}\Data/grade_line.csv")

if __name__ == '__main__':
    #输入要求
    request = input();
    #根据分数获取排名
    if(request == "get_rank"):
        score = input()
        rank = process.get_rank(score, data1)
        print(rank)
    if(request == "generate"):
        rank = input()
        wish = input()
        cinn = wish.split()
        for major in cinn:
            cinn = wish.split()
            rep = []
            eep = []
            for major in cinn:
                fl = pd.read_csv(f"{Gaokao_path}\Data\sorts/{major}.csv")
                n = 0
                for i in fl["投档最低位次"]:
                    n = n + 1
                    if abs(int(i) - int(rank)) <= 1000:
                        date = fl.iloc[n:n + 1, 0:4]
                        rep.append(date.to_string(header=False))
            for i in rep:
                t = i.split()[1:]
                t[0] = t[0][2:]
                t[1] = t[1][4:]
                eep.append(t)
                eep.append(t)
        df = pd.DataFrame(eep, columns=["专业名称", "学校名称", "计划录取人数", "最低录取名次"])
        df.to_csv(f"{Gaokao_path}\Data/result.csv")


