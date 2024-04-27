using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Day16 : MonoBehaviour
{
    private string puzzleInput = "59723517898690342336085619027921111260000667417052529433894092649779685557557996383085708903241535436786723718804155370155263736632861535632645335233170435646844328735934063129720822438983948765830873108060969395372667944081201020154126736565212455403582565814037568332106043336657972906297306993727714730061029321153984390658949013821918352341503629705587666779681013358053312990709423156110291835794179056432958537796855287734217125615700199928915524410743382078079059706420865085147514027374485354815106354367548002650415494525590292210440827027951624280115914909910917047084328588833201558964370296841789611989343040407348115608623432403085634084";
    public int[] puzzleArray;
    private int[] basePattern = { 0, 1, 0, -1 };
    private int total;
    private int moduloTotal;

    void Awake()
    {
        puzzleArray = puzzleInput.Select(c => c - '0').ToArray();
    }

    void Start()
    {
        for (int finalLoop = 0; finalLoop < 100; finalLoop++)
        {
            List<int> newInput = new List<int>();

            for (int i = 0; i < puzzleArray.Length; i++)
            {
                int tempInputs = FFT(i);
                newInput.Add(tempInputs);
            }

            puzzleArray = newInput.ToArray();
        }
    }

    private int FFT(int i)
    {
        List<int> newPattern = PatternCreator(i);
        total = 0;

        for (int offset = 0; offset < puzzleInput.Length; offset++)
        {
            int multiplication = puzzleArray[0 + offset] * newPattern[0 + offset];
            total += multiplication;
        }
        moduloTotal = Mathf.Abs(total) % 10;

        return moduloTotal;
    }

    private List<int> PatternCreator(int i)
    {
        List<int> PatternBuilder = new List<int>();

        for (int duplicate = 0; duplicate <= (puzzleArray.Length / 4); duplicate++)
        {
            for (int loop = 0; loop < i + 1; loop++)
            {
                PatternBuilder.Add(basePattern[0]);
            }
            for (int loop = 0; loop < i + 1; loop++)
            {
                PatternBuilder.Add(basePattern[1]);
            }
            for (int loop = 0; loop < i + 1; loop++)
            {
                PatternBuilder.Add(basePattern[2]);
            }
            for (int loop = 0; loop < i + 1; loop++)
            {
                PatternBuilder.Add(basePattern[3]);
            }
        }

        PatternBuilder.RemoveAt(0);

        return PatternBuilder;
    }
}
