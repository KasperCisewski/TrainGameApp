import React, { useState } from 'react';
import { connect } from 'react-redux';
import { MainWrapper } from './Main.style';
import TextInput from '../../common/TextInput';
import Button from "../../common/Button";
import { History } from "history";

interface Props {
	history: History,
	_changeNickname: any
}

const Main: React.FC<Props> = ({
	history,
	_changeNickname
}: Props) => {
	const [nickname, changeNickname] = useState('');
	const [ticket, changeTicket] = useState('');
	const [wasSubmittedOnce, changeSubmittedState] = useState(false);

	const goToGame = () => {
		changeSubmittedState(true);
		if (!nickname || ticket.length !== 11) {
			return;
		}

		_changeNickname(nickname);

		history.push('/game');
	};

	const validateNickname = (nickname: string) => nickname.length <= 12;

	const validateTicket = (ticket: string) => ticket.length <= 11;

	return (
		<MainWrapper>
			<TextInput width="70%" errorMessage={wasSubmittedOnce && !nickname ? 'max 12 characters' : ''} value={nickname} onChange={e => validateNickname(e.target.value) && changeNickname(e.target.value)} type="text" placeholder="Nickname"/>
			<TextInput width="70%" errorMessage={wasSubmittedOnce && ticket.length !== 11 ? 'equal to 10 characters' : ''} value={ticket} onChange={e => validateTicket(e.target.value) && changeTicket(e.target.value.toUpperCase())} type="text" placeholder="Ticket ID"/>
			<Button padding="10px 0" width="70%" label="PLAY" onClick={goToGame}/>
		</MainWrapper>
	)
};

const mapDispatch = (dispatch: any )=> ({
	_changeNickname: dispatch.generalModel.changeNickname
});

const mapState = (state: any) => ({

});

export default connect(
	mapState,
	mapDispatch
)(Main);