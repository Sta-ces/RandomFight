using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcul
{
	public float ValueToPercentage(float _num, float _maxNum, float _minNum = 0){
        return ((_num - _minNum) * 100) / (_maxNum - _minNum);
    }

    public float PercentageToValue(float _percent, float _maxNum, float _minNum = 0){
    	return (_percent * (_maxNum - _minNum) / 100) + _minNum;
    }

    public int Random(){
    	return 0;
    }
}
