using UnityEngine;
using System.Collections;

public class LessonManagerScript : MonoBehaviour {

	private static ArrayList quizStatuses = new ArrayList();

	public void init(int numQuizzes){
		for (int i=0; i < numQuizzes; i++) {
			quizStatuses.Add (true);
		}
	}

	public void setQuizCompleted(int quizNum){
		quizStatuses[quizNum - 1] = false;
	}

	public void loadQuiz(int quizNum){
		if ((bool)quizStatuses [quizNum - 1]) {
			Application.LoadLevel(16);
		} else {
			Application.LoadLevel(18);
		}
	}
}
