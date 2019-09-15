import styled, { keyframes } from 'styled-components';

const bounce = keyframes`
	0% {
		transform: translateX(0);
	}
	50% {
		transform: translateX(128px);
	}
	100% {
		transform: translateX(0);
	}
`;

export const ActivityIndicatorWrapper = styled.div`
	width: 128px;
	height: 32px;
	background: ${props => props.theme.ligthblue};
	position: relative;
	overflow: hidden;
	border-radius: 4px;
	& > div {
		position: absolute;
		top: 0;
		left: -32px;
		width: 64px;
		height: 100%;
		background: ${props => props.theme.darkblue};
		animation: ${bounce} 1.75s ease-in-out infinite;
	}
`;