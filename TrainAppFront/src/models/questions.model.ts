import {getInitialQuestionR} from "../api/questions.api";

const questionsModel = {
	state: {
		currentQuestion: null,
		accPoints: 0,
		lastQuestionUpdate: null
	},
	reducers: {
		incrementPoints(state: any, payload: number) {
			return {
				...state,
				accPoints: payload < 0 ? state.accPoints : state.accPoints + payload
			}
		},
		changeQuestion(state: any, payload: any) {
			const points = 1000 - Math.floor((Date.now() - state.lastQuestionUpdate) / 10);
			return {
				...state,
				currentQuestion: {
					questionText: payload.QuestionText,
					questionId: payload.QuestionId,
					answers: payload.Answers
				},
				lastQuestionUpdate: Date.now(),
				accPoints: points > 0 && payload.IsLastAnswerWasCorrect ? state.accPoints + points : state.accPoints
			}
		},
		onGetInitialQuestion(state: any, payload: any) {
			return {
				...state,
				currentQuestion: payload,
				lastQuestionUpdate: Date.now()
			}
		}
	},
	effects: {
		async getInitialQuestion() {
			const data = await getInitialQuestionR();

			// @ts-ignore
			this.onGetInitialQuestion(data.data);
		}
	}
};

export default questionsModel;