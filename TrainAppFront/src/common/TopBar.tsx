import React from 'react';
import { connect } from 'react-redux';
import { TopBarWrapper } from "./TopBar.style";
import {backIcon, brandLogo} from '../assets';
import { History } from "history";
import {withRouter} from "react-router";

interface Props {
	history: History,
	accPoints: number
}

interface dicI {
	[key: string]: string
}

const dic: dicI = {
	'/game': '/',
	'/quiz': '/game',
	'/ranking': '/game'
};

const TopBar: React.FC<Props> = ({
	history,
	accPoints
}: Props) => {

	const redirect = (path: string) => {
		if (path === '/') {
			window.location.replace("https://www.intercity.pl/pl/");
			return;
		}
		history.push(dic[path]);
	};

	const isBackVisible = !['/quiz'].includes(history.location.pathname);

	return (
		<TopBarWrapper backVisible={isBackVisible}>
			<img src={brandLogo} alt=""/>
			{
				 isBackVisible && (
					<img src={backIcon} alt="" onClick={() => redirect(history.location.pathname)}/>
				)
			}
			{
				history.location.pathname === '/quiz' && (
					<span>{accPoints} Pts</span>
				)
			}
		</TopBarWrapper>
	)
};

const mapState = (state: any) => ({
	accPoints: state.questionsModel.accPoints
});

const mapDispatch = (dispatch: any) => ({

});

export default withRouter(
	// @ts-ignore
	connect(
		mapState,
		mapDispatch
	)(TopBar)
);