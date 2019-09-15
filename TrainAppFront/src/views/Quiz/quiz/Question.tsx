import React from 'react';
import { QuestionWrapper } from './Question.style';

interface answer {
	answerText: string
	id: number
	questionId: number,
	answerId: number
	AnswerText: string
	AnswerId: number
}

interface question {
	questionText: string
	questionId: number
}

interface Props {
	question: question,
	answers: [answer, answer, answer, answer]
	onAnswer: any
}

const Question: React.FC<Props> = ({
	question,
	answers,
	onAnswer
}: Props) => {
	return (
		<QuestionWrapper>
			<span>{question.questionText}</span>
			<div>
				{
					answers.map(answer => (
						<div key={answer.answerText} onClick={() => onAnswer({
							questionId: question.questionId,
							answerId: answer.answerId || answer.AnswerId
						})}>
							<span>{answer.answerText || answer.AnswerText}</span>
						</div>
					))
				}
			</div>
		</QuestionWrapper>
	)
};

export default Question;