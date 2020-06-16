using System;
using System.Collections.Generic;
using System.Text;

namespace 动态规划算法
{
    //硬币找零文题
    public class CoinQuestion
    {
        //硬币找零问题：假设我们有几种不同币值的硬币 v1，v2，……，vn（单位是元）。如果我们要支付 w 元，求最少需要多少个硬币。
        //比如，我们有 3 种不同的硬币，1 元、3 元、5 元，我们要支付 9 元，最少需要 3 个硬币（3 个 3 元的硬币）。

        public int CoinChange(int[] coins, int n, int money)
        {
            List<int[]> states = new List<int[]>();
            states.Add(new int[money + 1]);
            //初始化第一次挑选
            for (int i = 0; i < n; i++)
            {
                if (coins[i]==money)
                {
                    return 1;
                }
                states[0][coins[i]] = coins[i];
            }
            int index = 1;
            int currentMoney = 0;
            while (true)
            {
                states.Add(new int[money + 1]);
     
                for (int i = 0; i < money + 1; i++)
                {
                    if (states[index - 1][i] > 0)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            currentMoney = states[index - 1][i] + coins[j];
                            if (currentMoney == money)
                            {
                                return index+1;
                            }
                            if (currentMoney<= money)
                            {
                                states[index][currentMoney] = currentMoney;
                            }                  
                        }
                    }
                }
                index++;

            }

        }
    }
}
