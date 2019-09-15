import React from 'react';
import { BottomBarWrapper, BottomBarItem } from './BottomBar.style';
import { History } from "history";
import {withRouter} from "react-router";
import bottomBarOptions from './bottomBarOptions';

interface Props {
	history: History
}

const BottomBar: React.FC<Props> = ({
	history
}: Props) => {
	console.log(history.location.pathname)
	const isVisible = [
		'/game',
		'/ranking',
		'/stats'
	].includes(history.location.pathname);

	return isVisible ? (
		<BottomBarWrapper>
			{
				bottomBarOptions.map(item => (
					<BottomBarItem key={item.label} selected={item.path === history.location.pathname} onClick={() => history.push(item.path)}>
						<div> </div>
						<img src={item.icon} alt=""/>
						<span>{item.label}</span>
					</BottomBarItem>
				))
			}
		</BottomBarWrapper>
	) : null
};

export default withRouter(BottomBar);