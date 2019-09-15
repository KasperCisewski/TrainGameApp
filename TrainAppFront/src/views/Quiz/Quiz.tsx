import React, { useState, useEffect, useContext } from 'react';
import { connect } from 'react-redux';
import { QuizWrapper } from './Quiz.style';
import Question from "./quiz/Question";
import LoadingScreen from "./quiz/LoadingScreen";
import {WebsocketContext} from "../../common/WebsocketProvider";

const Quiz: React.FC<any> = ({
	currentQuestion,
	getInitialQuestion,
	incrementPoints
}) => {
	const [isLoading, changeLoadState] = useState(true);
	const [finished, changeFinish] = useState(false);
	const [questionStart, changeQuestionStart] = useState(Date.now());

	const client = useContext(WebsocketContext);

	const checkQuestion = ({ questionId, answerId }: any) => {
		const obj = {
			questionId,
			answerId,
			token: 'FO'
		};

		client.send(JSON.stringify(obj));
	};

	useEffect(() => {
		getInitialQuestion()
			.finally(() => changeLoadState(false));
	}, []);

	return !isLoading ? (
		<QuizWrapper>
			{
				currentQuestion && (
					<Question
						question={currentQuestion}
						onAnswer={checkQuestion}
						answers={currentQuestion.answers}/>
				)
			}
		</QuizWrapper>
	) : (
		<LoadingScreen shouldClose={finished} closeCallback={() => {
			changeLoadState(false);
			changeFinish(false);
		}}/>
	)
};

const mapState = (state: any) => ({
	currentQuestion: state.questionsModel.currentQuestion
});

const mapDispatch = (dispatch: any) => ({
	getInitialQuestion: dispatch.questionsModel.getInitialQuestion,
	incrementPoints: dispatch.questionsModel.incrementPoints
});

export default connect(
	mapState,
	mapDispatch
)(Quiz);