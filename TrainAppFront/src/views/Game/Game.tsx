import React from 'react';
import { GameWrapper } from './Game.style';
import Button from "../../common/Button";
import { History } from "history";

interface Props {
	history: History
}

const Game: React.FC<Props> = ({
	history
}: Props) => {

	return (
		<GameWrapper>
			<Button padding="15px 5px" margin="24px 0" width="70%" label="? ? ? ?" onClick={() => {}}/>
			<Button padding="15px 5px" margin="24px 0" width="70%" label="Quiz" onClick={() => history.push('/quiz')}/>
			<Button padding="15px 5px" margin="24px 0" width="70%" label="Pattern matching" onClick={() => {}}/>
		</GameWrapper>
	)
};

export default Game;
