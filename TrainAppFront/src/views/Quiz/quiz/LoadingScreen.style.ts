import styled, { keyframes} from 'styled-components';
import {loadingScreenBackground} from "../../../assets";

const slideIn = keyframes`
	0% {
		opacity: 0;
	}
	100% {
		opacity: 1;
	}
`;

const slideOut = keyframes`
	0% {
		opacity: 1;
	}
	100% {
		opacity: 0;
	}
`;

interface LoadingScreenWrapperProps {
	isClosing: boolean
}

export const LoadingScreenWrapper = styled.div<LoadingScreenWrapperProps>`
	background: url(${loadingScreenBackground});
	background-size: cover;
  background-repeat: no-repeat;
	height: 90vh;
	padding: 0 12px;
	display: flex;
	flex-direction: column;
	justify-content: center;
	align-items: center;
	position: relative;
	color: ${props => props.theme.white};
	text-align: center;
	animation: ${props => props.isClosing ? slideOut : slideIn} .5s ease-in-out;
	& > div:first-child {
		position: absolute;
		top: 0;
		left: 0;
		background: rgba(0, 0, 0, 0.6);
		height: 100%;
		width: 100vw;;
	}
	& > span {
		margin-bottom: 16px;
		font-size: 24px;
		z-index: 9;
	}
`;